// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.CommandLine;
using System.IO;
using System.IO.Abstractions.TestingHelpers;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using NetTestRegimentation.XUnit.Logging;
using Whipstaff.CommandLine.Hosting;
using Xunit;

namespace NetTestRegimentation.IntegrationTests.SourceGenerator.DotNetTool
{
    /// <summary>
    /// Integration tests for <see cref="NetTestRegimentation.SourceGenerator.DotNetTool.Program"/>.
    /// </summary>
    public static class ProgramTests
    {
        /// <summary>
        /// Integration test for <see cref="NetTestRegimentation.SourceGenerator.DotNetTool.Program.RunJob(string[], System.Func{System.CommandLine.RootCommand, System.CommandLine.CommandLineConfiguration}?)"/> method.
        /// </summary>
        public sealed class RunJobMethod : TestWithLoggingBase
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="RunJobMethod"/> class.
            /// </summary>
            /// <param name="output">XUnit Test Output Helper.</param>
            public RunJobMethod(ITestOutputHelper output)
                : base(output)
            {
            }

            /// <summary>
            /// Test that a successful run of the source generator tool generates code and returns zero.
            /// </summary>
            /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
            [Fact]
            public async Task GeneratesCodeAndReturnsZeroAsync()
            {
                await using (var outputWriter = new StringWriter())
                await using (var errorWriter = new StringWriter())
                {
                    Console.SetOut(outputWriter);
                    Console.SetError(errorWriter);

                    var args = new[]
                    {
                        "--project-path",
                        "../../../../NetTestRegimentation.UnitTests/NetTestRegimentation.UnitTests.csproj",
                        "--whatif"
                    };
                    var result = await NetTestRegimentation.SourceGenerator.DotNetTool.Program.RunJob(
                        args,
                        rootCommand => XUnitTestHelpers.CreateTestConsoleIntegration(rootCommand, outputWriter, errorWriter));

#pragma warning disable CA1848
                    Logger.LogInformation("Console output: {ConsoleOutput}", outputWriter.ToString());
                    Logger.LogInformation("Console error: {ConsoleError}", errorWriter.ToString());
#pragma warning restore CA1848

                    Assert.Equal(0, result);
                }
            }
        }
    }
}
