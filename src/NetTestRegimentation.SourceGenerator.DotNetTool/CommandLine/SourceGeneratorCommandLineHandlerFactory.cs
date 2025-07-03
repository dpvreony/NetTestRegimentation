// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.CommandLine;
using System.IO;
using System.IO.Abstractions;
using Whipstaff.CommandLine;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.CommandLine
{
    /// <summary>
    /// Factory for creating the root command and binder.
    /// </summary>
    public sealed class SourceGeneratorCommandLineHandlerFactory : IRootCommandAndBinderFactory<SourceGeneratorCommandLineArgModelBinder>
    {
        /// <inheritdoc/>
        public RootCommandAndBinderModel<SourceGeneratorCommandLineArgModelBinder> GetRootCommandAndBinder(IFileSystem fileSystem)
        {
#pragma warning disable CA1861 // Avoid constant arrays as arguments
            var testProjectPathOption = new Option<FileInfo>(
                "--project-path",
                "-a")
            {
                Description = "Path to the project to generate code in.",
                Required = true
            }.SpecificFileExtensionOnly(
                fileSystem,
                ".csproj")
                .ExistingOnly(fileSystem);

            var rootCommand = new RootCommand("Creates an Entity Framework Diagram from a DbContext")
            {
                testProjectPathOption
            };

            return new RootCommandAndBinderModel<SourceGeneratorCommandLineArgModelBinder>(
                rootCommand,
                new SourceGeneratorCommandLineArgModelBinder(testProjectPathOption));
        }
    }
}
