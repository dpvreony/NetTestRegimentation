// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.SourceGenerator
{
    /// <summary>
    /// In-memory implementation of <see cref="AnalyzerConfigOptions"/> to allow us to inject options we pick up from msbuild.
    /// </summary>
    public sealed class InMemoryAnalyzerConfigOptions : AnalyzerConfigOptions
    {
        private readonly Dictionary<string, string> _options = new();

        /// <summary>
        /// Adds a new option to the in-memory options dictionary.
        /// </summary>
        /// <param name="key">Name of the option.</param>
        /// <param name="value">Value for the option.</param>
        public void Add(string key, string value)
        {
            _options.Add(key, value);
        }

        /// <inheritdoc />
        public override bool TryGetValue(string key, [NotNullWhen(true)] out string? value)
        {
            return _options.TryGetValue(key, out value);
        }
    }
}
