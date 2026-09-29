// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Whipstaff.Runtime.Extensions;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.SourceGenerator
{
    /// <summary>
    /// Source generator that generates code for a test project.
    /// </summary>
    public sealed class TestProjectSourceGenerator : IIncrementalGenerator
    {
        /// <inheritdoc/>
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var classSymbols = context.CompilationProvider.SelectMany((compilation, token) =>
                    compilation.References
                        .Select(r => compilation.GetAssemblyOrModuleSymbol(r))
                        .OfType<IAssemblySymbol>()
                        .SelectMany(static assembly => GetAllTypes(assembly.GlobalNamespace))
                        .Where(static type => IsDesiredType(type)))
                .Combine(context.ParseOptionsProvider)
                .Combine(context.CompilationProvider)
                .Select(static (tuple1, _) => (
                        NamedTypeSymbol: tuple1.Left.Left,
                        ParseOptions: tuple1.Left.Right,
                        Compilation: tuple1.Right));

            context.RegisterSourceOutput(
                classSymbols,
                static (productionContext, tuple) => DoGeneration(
                    productionContext,
                    tuple.NamedTypeSymbol,
                    tuple.ParseOptions,
                    tuple.Compilation));
        }

        private static bool IsDesiredAssembly(IAssemblySymbol assembly)
        {
            var allowedAssemblyNames = new[] { "NetTestRegimentation", "nettestregimentation-sourcegen" };

            return allowedAssemblyNames.Contains(assembly.Name);
        }

        private static bool IsDesiredType(INamedTypeSymbol type)
        {
            return type.TypeKind == TypeKind.Class && type is
            {
                IsAbstract: false,
                DeclaredAccessibility: Accessibility.Public
            };
        }

        private static IEnumerable<INamedTypeSymbol> GetAllTypes(INamespaceSymbol @namespace)
        {
            foreach (var type in @namespace.GetTypeMembers())
            {
                yield return type;
            }

            foreach (var ns in @namespace.GetNamespaceMembers())
            {
                foreach (var type in GetAllTypes(ns))
                {
                    yield return type;
                }
            }
        }

        private static string GetSafeFileName(INamedTypeSymbol symbol)
        {
            var name = symbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);

            // Remove or replace other invalid filename characters
            var invalidChars = System.IO.Path.GetInvalidFileNameChars();
            foreach (var c in invalidChars)
            {
                name = name.Replace(c, '_');
            }

            return name;
        }

        private static string GetFullyQualifiedMemberSignature(INamedTypeSymbol namedTypeSymbol, IMethodSymbol method)
        {
            var genericTypeParams = method.TypeParameters.Length > 0
                ? "<" + string.Join(",", method.TypeParameters.Select(tp => tp.Name)) + ">"
                : string.Empty;

            var paramList = string.Join(", ", method.Parameters
                .Select(p => p.Type.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat)));

            if (method.MethodKind == MethodKind.Constructor)
            {
                return string.IsNullOrEmpty(paramList)
                    ? $"{namedTypeSymbol.ToDisplayString()}()"
                    : $"{namedTypeSymbol.ToDisplayString()}({paramList})";
            }

            return string.IsNullOrEmpty(paramList)
                ? $"{namedTypeSymbol.ToDisplayString()}.{method.Name}{genericTypeParams}()"
                : $"{namedTypeSymbol.ToDisplayString()}.{method.Name}{genericTypeParams}({paramList})";
        }

        private static void DoGeneration(
            SourceProductionContext productionContext,
            INamedTypeSymbol namedTypeSymbol,
            ParseOptions parseOptions,
            Compilation compilation)
        {
            if (!IsDesiredAssembly(namedTypeSymbol.ContainingAssembly))
            {
                return;
            }

            var rootNamespace = compilation.Assembly.Name;
            var prefix = rootNamespace.Remove(".UnitTests", StringComparison.Ordinal);
            var subNamespace = namedTypeSymbol.ContainingNamespace.ToString()!.Remove(prefix, StringComparison.Ordinal);
            var testNamespace = $"{rootNamespace}{subNamespace}";

            var namespaceDeclaration = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName(testNamespace));

            // class level
            var classNameIdentifier = $"{namedTypeSymbol.Name}Tests";
            var modifiers = SyntaxFactory.TokenList(
                SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.StaticKeyword),
                SyntaxFactory.Token(SyntaxKind.PartialKeyword));

            var comments = new[]
            {
                SyntaxFactory.Comment("///<summary>"),
                SyntaxFactory.Comment($"/// Unit Tests for the class <see cref=\"{namedTypeSymbol.ToDisplayString()}\" />."),
                SyntaxFactory.Comment("///<summary>")
            };

            var classDeclaration = SyntaxFactory.ClassDeclaration(classNameIdentifier)
                .WithModifiers(modifiers)
                .WithLeadingTrivia(comments);

            classDeclaration = AddConstructorTests(
                classDeclaration,
                namedTypeSymbol);

            classDeclaration = AddMethodTests(
                classDeclaration,
                namedTypeSymbol);

            classDeclaration = AddPropertyTests(
                classDeclaration,
                namedTypeSymbol);

            namespaceDeclaration = namespaceDeclaration.AddMembers(classDeclaration);

            var cu = SyntaxFactory.CompilationUnit()
                .AddMembers(namespaceDeclaration)
                .NormalizeWhitespace();

            var sourceText = SyntaxFactory.SyntaxTree(
                    cu,
                    parseOptions,
                    encoding: Encoding.UTF8)
                .GetText();

            var safeFileName = GetSafeFileName(namedTypeSymbol);
            var hintName = $"{safeFileName}.g.cs";

            productionContext.AddSource(
                hintName,
                sourceText);
        }

        private static ClassDeclarationSyntax AddLoggingCapableConstructor(ClassDeclarationSyntax classDeclaration, INamedTypeSymbol namedTypeSymbol)
        {
            var attributeLists = SyntaxFactory.List<AttributeListSyntax>();
            var modifiers = SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword));
            var identifier = SyntaxFactory.Identifier(classDeclaration.Identifier.Text);

            var parameters = new List<ParameterSyntax>
            {
                SyntaxFactory.Parameter(SyntaxFactory.Identifier("output"))
                    .WithType(SyntaxFactory.ParseTypeName("global::Xunit.Abstractions.ITestOutputHelper"))
            };
            var separatedParameters = SyntaxFactory.SeparatedList(parameters);

            var parameterList = SyntaxFactory.ParameterList(separatedParameters);
            var initializer = SyntaxFactory.ConstructorInitializer(SyntaxKind.BaseConstructorInitializer)
                .WithArgumentList(SyntaxFactory.ArgumentList(SyntaxFactory.SingletonSeparatedList(
                    SyntaxFactory.Argument(SyntaxFactory.IdentifierName("output")))));
            var body = SyntaxFactory.Block();

            var loggingConstructor = SyntaxFactory.ConstructorDeclaration(
                attributeLists,
                modifiers,
                identifier,
                parameterList,
                initializer,
                body);

            return classDeclaration.AddMembers(loggingConstructor);
        }

        private static ClassDeclarationSyntax AddPropertyTests(
            ClassDeclarationSyntax classDeclaration,
            INamedTypeSymbol namedTypeSymbol)
        {
            // TODO: remove properties and events
            var methods = namedTypeSymbol.GetMembers()
                .Where(static c => c is
                                   {
                                       Kind: SymbolKind.Property,
                                       DeclaredAccessibility: Accessibility.Public
                                   }

                                   && !c.Name.Equals(".ctor", StringComparison.Ordinal));

            foreach (var method in methods)
            {
                // TODO: extend name with type arguments and method arguments.
                // TODO: work out the base implementation from NetTestRegimentation
                var constructorIdentifier = $"{method.Name}Property";
                var modifiers = SyntaxFactory.TokenList(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.SealedKeyword),
                    SyntaxFactory.Token(SyntaxKind.PartialKeyword));
                var ctorDeclaration = SyntaxFactory.ClassDeclaration(constructorIdentifier).WithModifiers(modifiers);
                ctorDeclaration = AddLoggingCapableConstructor(
                    ctorDeclaration,
                    namedTypeSymbol);

                classDeclaration = classDeclaration.AddMembers(ctorDeclaration);
            }

            return classDeclaration;
        }

        private static string GetTypeIdentifierName(ITypeSymbol type)
        {
            if (type is IArrayTypeSymbol arrayType)
            {
                return GetTypeIdentifierName(arrayType.ElementType) + "Array";
            }

            if (type is INamedTypeSymbol namedType)
            {
                var name = namedType.Name;
                var parts = name.Split('`');
                if (parts.Length > 1)
                {
                    name = parts[0];
                }

                // If the named type has concrete type arguments, use them.
                if (namedType.TypeArguments.Length > 0)
                {
                    var args = namedType.TypeArguments.Select(GetTypeIdentifierName).ToArray();
                    var joined = string.Join("And", args);
                    return $"{name}Of{joined}";
                }

                // If the type is generic but open (no type arguments available), use the type parameter names.
                if (namedType.Arity > 0 && namedType.TypeParameters.Length > 0)
                {
                    var args = namedType.TypeParameters.Select(tp => tp.Name).ToArray();
                    var joined = string.Join("And", args);
                    return $"{name}Of{joined}";
                }

                return name;
            }

            if (type is ITypeParameterSymbol typeParam)
            {
                return typeParam.Name;
            }

            return type.Name ?? type.ToDisplayString(SymbolDisplayFormat.MinimallyQualifiedFormat);
        }

        private static ClassDeclarationSyntax AddMethodTests(
            ClassDeclarationSyntax classDeclaration,
            INamedTypeSymbol namedTypeSymbol)
        {
            // TODO: remove properties and events
            var methods = namedTypeSymbol.GetMembers()
                .Where(static c => c is
                {
                    Kind: SymbolKind.Method,
                    DeclaredAccessibility: Accessibility.Public
                }

                && !c.Name.Equals(".ctor", StringComparison.Ordinal));

            foreach (var method in methods)
            {
                var methodSymbol = (IMethodSymbol)method;
                if (methodSymbol.MethodKind != MethodKind.Ordinary)
                {
                    continue;
                }

                if (!methodSymbol.CanBeReferencedByName)
                {
                    continue;
                }

                if (methodSymbol.OverriddenMethod != null && methodSymbol.OverriddenMethod.ContainingType.SpecialType == SpecialType.System_Object)
                {
                    // Ignore methods defined on System.Object (e.g. ToString, GetHashCode)
                    // unless they are overridden in the derived type. Overridden methods will
                    // have a different ContainingType, so only filter out members whose
                    // containing type is System.Object.
                    continue;
                }

                // Include method generic type parameter list (if any) and the parameter types in the summary
                var methodSignature = GetFullyQualifiedMemberSignature(namedTypeSymbol, methodSymbol);

                var constructorIdentifier = $"{method.Name}Method";

                var comments = new[]
                {
                    SyntaxFactory.Comment("///<summary>"),
                    SyntaxFactory.Comment($"/// Unit Tests for the method <see cref=\"{methodSignature}\" />."),
                    SyntaxFactory.Comment("///<summary>")
                };

                var modifiers = SyntaxFactory.TokenList(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                    SyntaxFactory.Token(SyntaxKind.SealedKeyword),
                    SyntaxFactory.Token(SyntaxKind.PartialKeyword));
                var ctorDeclaration = SyntaxFactory.ClassDeclaration(constructorIdentifier)
                    .WithModifiers(modifiers)
                    .WithLeadingTrivia(comments);

                ctorDeclaration = AddLoggingCapableConstructor(
                    ctorDeclaration,
                    namedTypeSymbol);

                classDeclaration = classDeclaration.AddMembers(ctorDeclaration);
            }

            return classDeclaration;
        }

        private static ClassDeclarationSyntax AddConstructorTests(
            ClassDeclarationSyntax classDeclaration,
            INamedTypeSymbol namedTypeSymbol)
        {
            var constructors = namedTypeSymbol.InstanceConstructors
                .Where(static c => c is
                {
                    DeclaredAccessibility: Accessibility.Public,
                    IsStatic: false
                });

            foreach (var constructor in constructors)
            {
                classDeclaration = AddConstructorMethodTestClass(
                    classDeclaration,
                    namedTypeSymbol,
                    constructor);
            }

            return classDeclaration;
        }

        private static ClassDeclarationSyntax AddConstructorMethodTestClass(
            ClassDeclarationSyntax classDeclaration,
            INamedTypeSymbol namedTypeSymbol,
            IMethodSymbol constructor)
        {
            // If the declaring type is generic, add a unique generic-arity identifier
            // before the parameter-based suffix so identifiers are unique per arity.
            var parameters = constructor.Parameters;
            string? genericArgsSuffix = null;
            var arity = namedTypeSymbol.Arity;
            if (arity > 0)
            {
                var tNames = Enumerable.Range(1, arity).Select(i => $"T{i}").ToArray();
                genericArgsSuffix = "Of" + string.Join("And", tNames);
            }

            var paramNames = parameters.Select(p => GetTypeIdentifierName(p.Type))
                .ToArray();

            string? paramNamesSuffix = null;
            if (paramNames.Length > 0)
            {
                paramNamesSuffix = "With" + string.Join("_", paramNames);
            }

            var nullableParameters = parameters.Where(p => p.Type.IsReferenceType)
                .ToArray();

            var constructorIdentifier = $"ConstructorMethod{genericArgsSuffix ?? string.Empty}{paramNamesSuffix}";
            var modifiers = SyntaxFactory.TokenList(
                SyntaxFactory.Token(SyntaxKind.PublicKeyword),
                SyntaxFactory.Token(SyntaxKind.SealedKeyword),
                SyntaxFactory.Token(SyntaxKind.PartialKeyword));

            var constructorSignature = GetFullyQualifiedMemberSignature(namedTypeSymbol, constructor);

            var comments = new[]
            {
                SyntaxFactory.Comment("///<summary>"),
                SyntaxFactory.Comment($"/// Unit Tests for the constructor <see cref=\"{constructorSignature}\" />."),
                SyntaxFactory.Comment("///<summary>")
            };

            var ctorDeclaration = SyntaxFactory.ClassDeclaration(constructorIdentifier)
                .WithModifiers(modifiers)
                .WithLeadingTrivia(comments);

            if (nullableParameters.Length > 0)
            {
                var nullableParametersList = string.Join(", ", nullableParameters.Select(p => p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat)));

                var nodes = new List<BaseTypeSyntax>
                {
                    SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName("global::NetTestRegimentation.XUnit.Logging.TestWithLoggingBase")),
                    SyntaxFactory.SimpleBaseType(SyntaxFactory.IdentifierName($"global::NetTestRegimentation.ITestMethodWithNullableParameters<{nullableParametersList}>"))
                };

                var baseItems = SyntaxFactory.SeparatedList(nodes);
                var baseList = SyntaxFactory.BaseList(baseItems);
                ctorDeclaration = ctorDeclaration.WithBaseList(baseList);
            }

            ctorDeclaration = AddLoggingCapableConstructor(
                ctorDeclaration,
                namedTypeSymbol);

            if (nullableParameters.Length > 0)
            {
                // Generate a theory method that forwards to EnsureThrowsArgumentNullException
                var theoryAttr = SyntaxFactory.AttributeList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.Attribute(SyntaxFactory.ParseName("global::Xunit.Theory"))));

                // Build the ClassData attribute pointing to the generated TheoryData type.
                var rootNamespace = namedTypeSymbol.ContainingAssembly.Name;
                var containingNs = namedTypeSymbol.ContainingNamespace?.ToString() ?? string.Empty;
                var subSuffix = containingNs.StartsWith(rootNamespace, StringComparison.Ordinal)
                    ? containingNs.Substring(rootNamespace.Length)
                    : containingNs;

                var dataNamespace = rootNamespace + ".TheoryData" + subSuffix;
                var classDataTypeName = $"global::{dataNamespace}.{namedTypeSymbol.Name}Tests.{constructorIdentifier}";

                var classDataAttr = SyntaxFactory.AttributeList(
                    SyntaxFactory.SingletonSeparatedList(
                        SyntaxFactory.Attribute(
                                SyntaxFactory.ParseName("global::Xunit.ClassData"))
                            .WithArgumentList(
                                SyntaxFactory.AttributeArgumentList(
                                    SyntaxFactory.SingletonSeparatedList(
                                        SyntaxFactory.AttributeArgument(
                                            SyntaxFactory.TypeOfExpression(
                                                SyntaxFactory.ParseTypeName(classDataTypeName))))))));

                // Build parameters matching the constructor parameters, fully-qualified types
                var methodParams = new List<ParameterSyntax>();
                var invocationArgs = new List<ArgumentSyntax>();
                foreach (var p in parameters)
                {
                    var fqType = p.Type.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
                    var param = SyntaxFactory.Parameter(SyntaxFactory.Identifier(p.Name))
                        .WithType(SyntaxFactory.ParseTypeName(fqType));
                    methodParams.Add(param);

                    invocationArgs.Add(SyntaxFactory.Argument(SyntaxFactory.IdentifierName(p.Name)));
                }

                // Add the expected parameter name for the thrown exception as the last argument
                var expectedParamNameParam = SyntaxFactory.Parameter(SyntaxFactory.Identifier("expectedParameterNameForException"))
                    .WithType(SyntaxFactory.ParseTypeName("global::System.String"));
                methodParams.Add(expectedParamNameParam);
                invocationArgs.Add(SyntaxFactory.Argument(SyntaxFactory.IdentifierName("expectedParameterNameForException")));

                var parameterList = SyntaxFactory.ParameterList(SyntaxFactory.SeparatedList(methodParams));

                var invocation = SyntaxFactory.ExpressionStatement(
                    SyntaxFactory.InvocationExpression(
                        SyntaxFactory.MemberAccessExpression(
                            SyntaxKind.SimpleMemberAccessExpression,
                            SyntaxFactory.ThisExpression(),
                            SyntaxFactory.IdentifierName("EnsureThrowsArgumentNullException")),
                        SyntaxFactory.ArgumentList(SyntaxFactory.SeparatedList(invocationArgs))));

                var methodDecl = SyntaxFactory.MethodDeclaration(
                        SyntaxFactory.PredefinedType(SyntaxFactory.Token(SyntaxKind.VoidKeyword)),
                        SyntaxFactory.Identifier("ThrowsArgumentNullException"))
                    .WithAttributeLists(SyntaxFactory.List(new[] { theoryAttr, classDataAttr }))
                    .WithModifiers(SyntaxFactory.TokenList(SyntaxFactory.Token(SyntaxKind.PublicKeyword)))
                    .WithParameterList(parameterList)
                    .WithBody(SyntaxFactory.Block(invocation));

                ctorDeclaration = ctorDeclaration.AddMembers(methodDecl);
            }

            return classDeclaration.AddMembers(ctorDeclaration);

            // TODO: add returns instance test
            // TODO: add null reference exception tests
        }
    }
}
