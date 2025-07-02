// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using Microsoft.Extensions.Logging;
using Whipstaff.Core.Logging;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.Logging
{
    /// <summary>
    /// Log message actions for <see cref="SourceGeneratorCommandLineJob"/>.
    /// </summary>
    public sealed class SourceGeneratorCommandLineJobLogMessageActions : ILogMessageActions<SourceGeneratorCommandLineJob>
    {
        private readonly Action<ILogger, Exception?> _startingHandleCommand;
        private readonly Action<ILogger, Exception?> _failedToFindRootCommand;
        private readonly Action<ILogger, Exception?> _unhandledException;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceGeneratorCommandLineJobLogMessageActions"/> class.
        /// </summary>
        public SourceGeneratorCommandLineJobLogMessageActions()
        {
            _startingHandleCommand = LoggerMessage.Define(
                LogLevel.Information,
                SourceGeneratorJobEventIdFactory.StartingHandleCommand(),
                "Starting execution of CLI job handler");

            _failedToFindRootCommand = LoggerMessage.Define(
                LogLevel.Error,
                SourceGeneratorJobEventIdFactory.FailedToFindRootCommand(),
                "Failed to find root command.");

            _unhandledException = LoggerMessage.Define(
                LogLevel.Error,
                SourceGeneratorJobEventIdFactory.UnhandledException(),
                "Unhandled Exception.");
        }

        internal void StartingHandleCommand(ILogger<SourceGeneratorCommandLineJob> logger)
        {
            _startingHandleCommand(logger, null);
        }

        internal void FailedToFindRootCommand(ILogger<SourceGeneratorCommandLineJob> logger)
        {
            _failedToFindRootCommand(logger, null);
        }

        internal void UnhandledException(ILogger<SourceGeneratorCommandLineJob> logger, Exception exception)
        {
            _unhandledException(logger, exception);
        }
    }
}
