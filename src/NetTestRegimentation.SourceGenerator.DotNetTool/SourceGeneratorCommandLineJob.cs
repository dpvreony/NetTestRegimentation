// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Immutable;
using System.IO.Abstractions;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis;
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
            LogMessageActionsWrapper.StartingHandleCommand();

            // get a list of project references using msbuild
            // get the project references into roslyn as options
            // iterate over the project references and get the namespaces, classes and methods.
            var analyzer = new TestProjectSourceGenerator()
                .AsSourceGenerator();

            var hasError = false;

            using (var workspace = MSBuildWorkspace.Create())
            {
                var project = await workspace.OpenProjectAsync(
                    commandLineArgModel.TestProjectPath.FullName,
                    cancellationToken: cancellationToken);

                // we need to inject the project references into the compilation options
                // as the source generator needs to know about them,
                // but it can't get them from the project directly.
                var analyzerConfigOptionsProvider = GetAnalyzerConfigOptionsProvider(project);

                var compilation = await project.GetCompilationAsync(cancellationToken);
                if (compilation == null)
                {
                    // TODO: warn about failure to get compilation object.
                    throw new InvalidOperationException("Failed to get compilation object");
                }

                var originalSyntaxTrees = compilation.SyntaxTrees.ToImmutableHashSet();

                compilation = compilation.RunGenerators(
                    analyzerConfigOptionsProvider,
                    out var diagnostics,
                    analyzer);

                if (diagnostics.Any())
                {
                    foreach (var diagnostic in diagnostics)
                    {
                        hasError |= diagnostic.Severity == DiagnosticSeverity.Error;

                        await Console.Error.WriteLineAsync(diagnostic.ToString())
                            .ConfigureAwait(false);
                    }
                }

                var allSyntaxTrees = compilation.SyntaxTrees.ToImmutableHashSet();
                var generatedSyntaxTrees = allSyntaxTrees.Except(originalSyntaxTrees).ToImmutableArray();

                if (generatedSyntaxTrees.IsEmpty)
                {
                    LogMessageActionsWrapper.NoGeneratedCode();
                }
                else
                {
                    LogMessageActionsWrapper.GeneratedCode(generatedSyntaxTrees.Length);
                    foreach (var syntaxTree in generatedSyntaxTrees)
                    {
                        LogMessageActionsWrapper.GeneratedCodeFile(syntaxTree.FilePath);
                        Console.WriteLine((await syntaxTree.GetTextAsync(cancellationToken)).ToString());
                    }
                }
            }

            return hasError ? 1 : 0;
        }

        private static InMemoryAnalyzerConfigOptionsProvider GetAnalyzerConfigOptionsProvider(Project project)
        {
            var globalOptions = new InMemoryAnalyzerConfigOptions();

            var projectReferences = project.AllProjectReferences;

            var references = projectReferences.Count > 0
                ? string.Join(",", projectReferences)
                : string.Empty;

            globalOptions.Add(
                "build_property.nettestregimentation_projectreferences",
                references);

            return new InMemoryAnalyzerConfigOptionsProvider(globalOptions);
        }
    }
}
