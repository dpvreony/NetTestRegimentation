// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Diagnostics;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.SourceGenerator
{
    public sealed class TestProjectSourceGenerator : IIncrementalGenerator
    {
        /// <inheritdoc/>
        public void Initialize(IncrementalGeneratorInitializationContext context)
        {
            var allowedAssemblyNames = new[] { "MyReferencedAssembly", "OtherLib" };

            var classSymbols = context.CompilationProvider.SelectMany((compilation, token) => compilation.GlobalNamespace.GetTypeMembers())
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

        private static string GetSafeFileName(INamedTypeSymbol symbol)
        {
            var name = symbol.ToString();

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
            var cu = SyntaxFactory.CompilationUnit()
                .AddMembers(namespaceDeclaration)
                .NormalizeWhitespace();

            var sourceText = SyntaxFactory.SyntaxTree(
                    cu,
                    parseOptions,
                    encoding: Encoding.UTF8)
                .GetText();

            var hintName = $"{GetSafeFileName(namedTypeSymbol)}.g.cs";

            productionContext.AddSource(
                hintName,
                sourceText);
        }
    }
}
