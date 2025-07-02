// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.CommandLine;
using System.CommandLine.Parsing;
using System.IO;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.CommandLine
{
    /// <summary>
    /// Binding logic for the command line arguments.
    /// </summary>
    public sealed class SourceGeneratorCommandLineArgModelBinder : IBinderBase<SourceGeneratorCommandLineArgModel>
    {
        private readonly Option<FileInfo> _testProjectPathOption;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceGeneratorCommandLineArgModelBinder"/> class.
        /// </summary>
        /// <param name="testProjectPathOptionOption">Test Project Path option to parse and bind against.</param>
        public SourceGeneratorCommandLineArgModelBinder(Option<FileInfo> testProjectPathOption)
        {
            ArgumentNullException.ThrowIfNull(testProjectPathOption);

            _testProjectPathOption = testProjectPathOption;
        }

        /// <inheritdoc/>
        public SourceGeneratorCommandLineArgModel GetBoundValue(ParseResult parseResult)
        {
            ArgumentNullException.ThrowIfNull(parseResult);

            var testProjectPath = parseResult.GetValue(_testProjectPathOption);

            return new SourceGeneratorCommandLineArgModel(
                testProjectPath!);
        }
    }
}
