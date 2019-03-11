using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Xunit;

namespace NetTestRegimentation.UnitTests
{
    [ExcludeFromCodeCoverage]
    public static class ITestAsyncMethodWithNullableParametersT10Test
    {
        public sealed class Throws : ITestAsyncMethodWithNullableParameters<
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
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource = ObjectArrayHelper.GetArgObjectArrayOfArray(10);

            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                FakeObject arg1,
                FakeObject arg2,
                FakeObject arg3,
                FakeObject arg4,
                FakeObject arg5,
                FakeObject arg6,
                FakeObject arg7,
                FakeObject arg8,
                FakeObject arg9,
                FakeObject arg10,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => ArgumentHelpers.ThrowIfNullAsync(
                    arg1,
                    arg2,
                    arg3,
                    arg4,
                    arg5,
                    arg6,
                    arg7,
                    arg8,
                    arg9,
                    arg10,
                    expectedParameterNameForException));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}