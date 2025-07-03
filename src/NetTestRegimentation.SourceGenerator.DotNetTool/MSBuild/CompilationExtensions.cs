// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.MSBuild
{
    /// <summary>
    /// Extensions for <see cref="Compilation"/> to run source generators.
    /// </summary>
    public static class CompilationExtensions
    {
        /// <summary>
        /// Runs the specified source generators on the given compilation and returns the updated compilation along with diagnostics.
        /// </summary>
        /// <param name="compilation">MSBuild Compilation object to run the generation on.</param>
        /// <param name="analyzerConfigOptionsProvider">Options provider to inject into the source generator. Used to provide configuration to source generators.</param>
        /// <param name="diagnostics">Output of diagnostics returned by the compilation object during source generation.</param>
        /// <param name="generators">Array of generators to use.</param>
        /// <returns>Modified compilation object.</returns>
        public static Compilation RunGenerators(
            this Compilation compilation,
            AnalyzerConfigOptionsProvider? analyzerConfigOptionsProvider,
            out ImmutableArray<Diagnostic> diagnostics,
            params ISourceGenerator[] generators)
        {
            ArgumentNullException.ThrowIfNull(compilation);

            var driver = compilation.CreateDriver(
                analyzerConfigOptionsProvider,
                generators);

            driver.RunGeneratorsAndUpdateCompilation(
                compilation,
                out var updatedCompilation,
                out diagnostics);

            return updatedCompilation;
        }

        private static CSharpGeneratorDriver CreateDriver(
            this Compilation compilation,
            AnalyzerConfigOptionsProvider? analyzerConfigOptionsProvider,
            params ISourceGenerator[] generators) => CSharpGeneratorDriver.Create(
            generators: [..generators],
            additionalTexts: ImmutableArray<AdditionalText>.Empty,
            parseOptions: (CSharpParseOptions)compilation.SyntaxTrees.First().Options,
            optionsProvider: analyzerConfigOptionsProvider);
    }
}
