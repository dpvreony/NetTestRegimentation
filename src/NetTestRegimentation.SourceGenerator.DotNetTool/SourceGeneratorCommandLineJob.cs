// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO.Abstractions;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using Microsoft.CodeAnalysis.MSBuild;
using NetTestRegimentation.SourceGenerator.DotNetTool.CommandLine;
using NetTestRegimentation.SourceGenerator.DotNetTool.Logging;
using NetTestRegimentation.SourceGenerator.DotNetTool.MSBuild;
using NetTestRegimentation.SourceGenerator.DotNetTool.SourceGenerator;
using Whipstaff.CommandLine;

namespace NetTestRegimentation.SourceGenerator.DotNetTool
{
    /// <summary>
    /// Process manager that handles the Source generator command line job.
    /// </summary>
    public sealed class SourceGeneratorCommandLineJob : AbstractCommandLineHandler<SourceGeneratorCommandLineArgModel, SourceGeneratorCommandLineJobLogMessageActionsWrapper>
    {
        private readonly IFileSystem _fileSystem;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceGeneratorCommandLineJob"/> class.
        /// </summary>
        /// <param name="commandLineJobLogMessageActionsWrapper">Wrapper for logging framework messages.</param>
        /// <param name="fileSystem">File System abstraction.</param>
        public SourceGeneratorCommandLineJob(
            SourceGeneratorCommandLineJobLogMessageActionsWrapper commandLineJobLogMessageActionsWrapper,
            IFileSystem fileSystem)
            : base(commandLineJobLogMessageActionsWrapper)
        {
            ArgumentNullException.ThrowIfNull(fileSystem);

            _fileSystem = fileSystem;
        }

        /// <inheritdoc/>
        protected override async Task<int> OnHandleCommand(SourceGeneratorCommandLineArgModel commandLineArgModel, CancellationToken cancellationToken)
        {
            ArgumentNullException.ThrowIfNull(commandLineArgModel);

            // get a list of project references using msbuild
            // get the project references into rosyln as options
            // iterate over the project references and get the namespaces, classes and methods.
            var analyzer = new TestProjectSourceGenerator()
                .AsSourceGenerator();

            using (var workspace = MSBuildWorkspace.Create())
            {
                var project = await workspace.OpenProjectAsync(
                    commandLineArgModel.TestProjectPath.FullName,
                    cancellationToken: cancellationToken);

                var compilation = await project.GetCompilationAsync(cancellationToken);
                if (compilation == null)
                {
                    // TODO: warn about failure to get compilation object.
                    throw new InvalidOperationException("Failed to get compilation object");
                }

                compilation.RunGenerators(
                    null,
                    out var diagnostics,
                    analyzer);
            }

            return 1;
        }
    }
}
