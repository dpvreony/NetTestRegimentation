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
    public static class ITestAsyncMethodWithNullableParametersT6Test
    {
        public sealed class Throws : ITestAsyncMethodWithNullableParameters<
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject,
            FakeObject>
        {
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource = ObjectArrayHelper.GetMoqArgObjectArrayOfArray(6);

            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                FakeObject arg1,
                FakeObject arg2,
                FakeObject arg3,
                FakeObject arg4,
                FakeObject arg5,
                FakeObject arg6,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => ArgumentHelpers.ThrowIfNullAsync(
                    arg1,
                    arg2,
                    arg3,
                    arg4,
                    arg5,
                    arg6,
                    expectedParameterNameForException));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}