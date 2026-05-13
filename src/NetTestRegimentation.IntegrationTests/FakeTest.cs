// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Xunit;

namespace NetTestRegimentation.IntegrationTests
{
    /// <summary>
    /// Fake test to satisfy the requirement of having at least one test in the assembly for the test runner to execute.
    /// </summary>
    public static class FakeTest
    {
        /// <summary>
        /// Test to ensure that the test runner can execute at least one test in the assembly. This test will always pass.
        /// </summary>
        [Fact]
        public static void Run()
        {
            Assert.True(true);
        }
    }
}
