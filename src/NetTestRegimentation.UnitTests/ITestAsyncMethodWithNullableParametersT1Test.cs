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
    public static class ITestAsyncMethodWithNullableParametersT1Test
    {
        public sealed class Throws : ITestAsyncMethodWithNullableParameters<FakeObject>
        {
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource = ObjectArrayHelper.GetMoqArgObjectArrayOfArray(1);

            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                FakeObject arg,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => ArgumentHelpers.ThrowIfNullAsync(arg, expectedParameterNameForException));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}
