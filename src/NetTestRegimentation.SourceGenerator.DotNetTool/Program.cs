// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.IO.Abstractions;
using System.Threading.Tasks;
using NetTestRegimentation.SourceGenerator.DotNetTool.CommandLine;
using NetTestRegimentation.SourceGenerator.DotNetTool.Logging;
using Whipstaff.CommandLine.Hosting;

namespace NetTestRegimentation.SourceGenerator.DotNetTool
{
    /// <summary>
    /// Hosts the program entry point.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Program entry point.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        /// <returns>0 for success, non 0 for failure.</returns>
        public static Task<int> Main(string[] args)
        {
            return HostRunner.RunSimpleCliJob<
                SourceGeneratorCommandLineJob,
                SourceGeneratorCommandLineArgModel,
                SourceGeneratorCommandLineArgModelBinder,
                SourceGeneratorCommandLineHandlerFactory>(
                args,
                (fileSystem, logger) => new SourceGeneratorCommandLineJob(
                    new SourceGeneratorCommandLineJobLogMessageActionsWrapper(
                        new SourceGeneratorCommandLineJobLogMessageActions(),
                        logger),
                    fileSystem),
                new FileSystem());
        }
    }
}
