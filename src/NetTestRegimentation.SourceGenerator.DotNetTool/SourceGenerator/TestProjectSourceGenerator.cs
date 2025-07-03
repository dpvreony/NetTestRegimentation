// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

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
                        .SelectMany(assembly => GetAllTypes(assembly.GlobalNamespace))
                        .Where(type => IsDesiredType(type)))
                .Combine(context.ParseOptionsProvider)
                .Select(
                    (tuple1, _) => (
                        NamedTypeSymbol: tuple1.Left,
                        ParseOptions: tuple1.Right));

            context.RegisterSourceOutput(
                classSymbols,
                static (productionContext, tuple) => DoGeneration(
                    productionContext,
                    tuple.NamedTypeSymbol,
                    tuple.ParseOptions));
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

        private static void DoGeneration(
            SourceProductionContext productionContext,
            INamedTypeSymbol namedTypeSymbol,
            ParseOptions parseOptions)
        {
            if (!IsDesiredAssembly(namedTypeSymbol.ContainingAssembly))
            {
                return;
            }

            var namespaceDeclaration = SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName("UnitTest"));
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
    }
}
