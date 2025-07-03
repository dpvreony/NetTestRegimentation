// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.CommandLine;
using System.IO;
using System.IO.Abstractions;
using Whipstaff.CommandLine;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.CommandLine
{
    /// <summary>
    /// Binding logic for the command line arguments.
    /// </summary>
    public sealed class SourceGeneratorCommandLineArgModelBinder : IBinderBase<SourceGeneratorCommandLineArgModel>
    {
        private readonly Option<FileInfo> _testProjectPathOption;
        private readonly Option<bool> _whatIfOption;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceGeneratorCommandLineArgModelBinder"/> class.
        /// </summary>
        /// <param name="testProjectPathOption">Test Project Path option to parse and bind against.</param>
        /// <param name="whatIfOption">Command line option model for the "What If" option to parse and bind against.</param>
        public SourceGeneratorCommandLineArgModelBinder(
            Option<FileInfo> testProjectPathOption,
            Option<bool> whatIfOption)
        {
            ArgumentNullException.ThrowIfNull(testProjectPathOption);
            ArgumentNullException.ThrowIfNull(whatIfOption);

            _testProjectPathOption = testProjectPathOption;
            _whatIfOption = whatIfOption;
        }

        /// <inheritdoc/>
        public SourceGeneratorCommandLineArgModel GetBoundValue(ParseResult parseResult)
        {
            ArgumentNullException.ThrowIfNull(parseResult);

            var testProjectPath = parseResult.GetValue(_testProjectPathOption);
            var whatIf = parseResult.GetValue(_whatIfOption);

            return new SourceGeneratorCommandLineArgModel(
                testProjectPath!,
                whatIf);
        }
    }
}
