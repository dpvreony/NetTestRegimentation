// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.IO;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.SourceGenerator
{
    /// <summary>
    /// In-memory implementation of <see cref="AnalyzerConfigOptionsProvider"/> to allow us to inject options we pick up from MSBuild.
    /// </summary>
    public sealed class InMemoryAnalyzerConfigOptionsProvider : AnalyzerConfigOptionsProvider
    {
        private readonly Dictionary<string, AnalyzerConfigOptions> _options = [];

        /// <summary>
        /// Initializes a new instance of the <see cref="InMemoryAnalyzerConfigOptionsProvider"/> class.
        /// </summary>
        /// <param name="globalOptions">Options to inject into the provider.</param>
        public InMemoryAnalyzerConfigOptionsProvider(AnalyzerConfigOptions globalOptions)
        {
            System.ArgumentNullException.ThrowIfNull(globalOptions);
            GlobalOptions = globalOptions;
        }

        /// <inheritdoc/>
        public override AnalyzerConfigOptions GlobalOptions { get; }

        /// <inheritdoc/>
        public override AnalyzerConfigOptions GetOptions(SyntaxTree tree)
        {
            System.ArgumentNullException.ThrowIfNull(tree);

            return GetOptions(Path.GetFileName(tree.FilePath));
        }

        /// <inheritdoc/>
        public override AnalyzerConfigOptions GetOptions(Microsoft.CodeAnalysis.AdditionalText textFile)
        {
            System.ArgumentNullException.ThrowIfNull(textFile);

            return GetOptions(Path.GetFileName(textFile.Path));
        }

        private AnalyzerConfigOptions GetOptions(string path)
        {
            if (!_options.TryGetValue(path, out var options))
            {
                options ??= new InMemoryAnalyzerConfigOptions();
                _options[path] = options;
            }

            return options;
        }
    }
}
