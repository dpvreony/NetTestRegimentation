﻿// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
// This file is licensed to you under the MIT license.
// See the LICENSE file in the project root for full license information.

using Moq;
using NetTestRegimentation.Moq;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace NetTestRegimentation.UnitTests.Moq
{
    /// <summary>
    /// Unit Tests for 2 nullable parameters through Moq.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class ITestAsyncMethodWithMoqNullableParametersT2Test
    {
#pragma warning disable CA1034 // Nested types should not be visible
        /// <inheritdoc />
        public sealed class Throws : ITestAsyncMethodWithMoqNullableParameters<
            FakeObject,
            FakeObject>
        {
            /// <summary>
            /// Gets the Test Data Source for the <see cref="ThrowsArgumentNullExceptionAsync"/> method.
            /// </summary>
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource => ObjectArrayHelper.GetMoqArgObjectArrayOfArray(2);

            /// <inheritdoc />
            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                Mock<FakeObject> arg1,
                Mock<FakeObject> arg2,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => ArgumentHelpers.ThrowIfNullAsync(
                    arg1?.Object,
                    arg2?.Object));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
#pragma warning restore CA1034 // Nested types should not be visible
    }
}
