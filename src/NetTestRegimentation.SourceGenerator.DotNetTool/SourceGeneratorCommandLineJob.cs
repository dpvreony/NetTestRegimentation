// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.IO.Abstractions;
using System.Threading;
using System.Threading.Tasks;
using NetTestRegimentation.SourceGenerator.DotNetTool.CommandLine;
using NetTestRegimentation.SourceGenerator.DotNetTool.Logging;
using Whipstaff.CommandLine;

namespace NetTestRegimentation.SourceGenerator.DotNetTool
{
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
        protected override Task<int> OnHandleCommand(SourceGeneratorCommandLineArgModel commandLineArgModel, CancellationToken cancellationToken)
        {
            return Task.FromResult(1);
        }
    }
}
