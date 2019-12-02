// Copyright (c) 2019 dpvreony and Contributors. All rights reserved.
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
    [ExcludeFromCodeCoverage]
    public static class ITestAsyncMethodWithMoqNullableParametersT16Test
    {
        public sealed class Throws : ITestAsyncMethodWithMoqNullableParameters<
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject>
        {
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource = ObjectArrayHelper.GetMoqArgObjectArrayOfArray(16);

            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                Mock<FakeObject> arg1,
                Mock<FakeObject> arg2,
                Mock<FakeObject> arg3,
                Mock<FakeObject> arg4,
                Mock<FakeObject> arg5,
                Mock<FakeObject> arg6,
                Mock<FakeObject> arg7,
                Mock<FakeObject> arg8,
                Mock<FakeObject> arg9,
                Mock<FakeObject> arg10,
                Mock<FakeObject> arg11,
                Mock<FakeObject> arg12,
                Mock<FakeObject> arg13,
                Mock<FakeObject> arg14,
                Mock<FakeObject> arg15,
                Mock<FakeObject> arg16,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => ArgumentHelpers.ThrowIfNullAsync(
                    arg1?.Object,
                    arg2?.Object,
                    arg3?.Object,
                    arg4?.Object,
                    arg5?.Object,
                    arg6?.Object,
                    arg7?.Object,
                    arg8?.Object,
                    arg9?.Object,
                    arg10?.Object,
                    arg11?.Object,
                    arg12?.Object,
                    arg13?.Object,
                    arg14?.Object,
                    arg15?.Object,
                    arg16?.Object,
                    expectedParameterNameForException));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}