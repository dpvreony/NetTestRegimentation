// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using Microsoft.Extensions.Logging;
using Whipstaff.Core.Logging;
using Whipstaff.Core.Logging.MessageActionWrappers;

namespace NetTestRegimentation.SourceGenerator.DotNetTool.Logging
{
    /// <summary>
    /// Log message actions wrapper for <see cref="SourceGeneratorCommandLineJob"/>.
    /// </summary>
    public sealed class SourceGeneratorCommandLineJobLogMessageActionsWrapper : ILogMessageActionsWrapper<SourceGeneratorCommandLineJob>, IWrapLogMessageActionUnhandledException
    {
        private readonly SourceGeneratorCommandLineJobLogMessageActions _commandLineJobLogMessageActions;

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceGeneratorCommandLineJobLogMessageActionsWrapper"/> class.
        /// </summary>
        /// <param name="commandLineJobLogMessageActions">Log Message actions for <see cref="SourceGeneratorCommandLineJob" />.</param>
        /// <param name="logger">Logging framework instance.</param>
        public SourceGeneratorCommandLineJobLogMessageActionsWrapper(
            SourceGeneratorCommandLineJobLogMessageActions commandLineJobLogMessageActions,
#pragma warning disable S6672
            ILogger<SourceGeneratorCommandLineJob> logger)
#pragma warning restore S6672
        {
            ArgumentNullException.ThrowIfNull(commandLineJobLogMessageActions);
            ArgumentNullException.ThrowIfNull(logger);

            _commandLineJobLogMessageActions = commandLineJobLogMessageActions;
            Logger = logger;
        }

        /// <inheritdoc/>
        public ILogger<SourceGeneratorCommandLineJob> Logger
        {
            get;
        }

        /// <summary>
        /// Log message action for when the command line job is starting.
        /// </summary>
        public void StartingHandleCommand()
        {
            _commandLineJobLogMessageActions.StartingHandleCommand(Logger);
        }

        /// <inheritdoc />
        public void UnhandledException(Exception exception)
        {
            _commandLineJobLogMessageActions.UnhandledException(Logger, exception);
        }
    }
}
