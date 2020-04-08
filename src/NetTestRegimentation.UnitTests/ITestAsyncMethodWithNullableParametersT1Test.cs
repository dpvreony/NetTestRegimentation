// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Xunit;

namespace NetTestRegimentation.UnitTests
{
    [ExcludeFromCodeCoverage]
    public static class ITestAsyncMethodWithNullableParametersT1Test
    {
        /// <inheritdoc />
        public sealed class Throws : ITestAsyncMethodWithNullableParameters<FakeObject>
        {
            /// <summary>
            /// Gets the Test Data Source for the <see cref="ThrowsArgumentNullExceptionAsync"/> method.
            /// </summary>
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource => ObjectArrayHelper.GetArgObjectArrayOfArray(1);

            /// <inheritdoc />
            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                FakeObject arg,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => ArgumentHelpers.ThrowIfNullAsync(arg, expectedParameterNameForException)).ConfigureAwait(false);
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}
