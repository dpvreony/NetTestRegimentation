// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using NetTestRegimentation.XUnit.Logging;
using Xunit;

namespace NetTestRegimentation.IntegrationTests.SourceGenerator.DotNetTool
{
    /// <summary>
    /// Integration tests for <see cref="NetTestRegimentation.SourceGenerator.DotNetTool.Program"/>.
    /// </summary>
    public static class ProgramTests
    {
        /// <summary>
        /// Integration test for <see cref="NetTestRegimentation.SourceGenerator.DotNetTool.Program.Main(string[])"/> method.
        /// </summary>
        public sealed class MainMethod : TestWithLoggingBase
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="MainMethod"/> class.
            /// </summary>
            /// <param name="output">XUnit Test Output Helper.</param>
            public MainMethod(ITestOutputHelper output)
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
                var args = new[]
                {
                    "--test-project-path",
                    "../../../NetTestRegimentation.UnitTests.csproj",
                    "--whatif"
                };
                var result = await NetTestRegimentation.SourceGenerator.DotNetTool.Program.Main(args);
            }
        }
    }
}
