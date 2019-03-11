using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using Xunit;

namespace NetTestRegimentation.UnitTests
{
    [ExcludeFromCodeCoverage]
    public static class ITestAsyncMethodWithNullableParametersT2Test
    {
        public sealed class Throws : ITestAsyncMethodWithNullableParameters<
            FakeObject,
            FakeObject>
        {
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource = ObjectArrayHelper.GetArgObjectArrayOfArray(2);

            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                FakeObject arg1,
                FakeObject arg2,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => ArgumentHelpers.ThrowIfNullAsync(
                    arg1,
                    arg2,
                    expectedParameterNameForException));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}
