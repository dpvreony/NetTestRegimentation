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
    public static class ITestAsyncMethodWithMoqNullableParametersT2Test
    {
        public sealed class Throws : ITestAsyncMethodWithMoqNullableParameters<
            FakeObject,
            FakeObject>
        {
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource = ObjectArrayHelper.GetMoqArgObjectArrayOfArray(2);

            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                Mock<FakeObject> arg1,
                Mock<FakeObject> arg2,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => ArgumentHelpers.ThrowIfNullAsync(
                    arg1?.Object,
                    arg2?.Object,
                    expectedParameterNameForException));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}
