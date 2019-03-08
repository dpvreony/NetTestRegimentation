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
        public sealed class Throws : ITestAsyncMethodWithMoqNullableParameters<string, string>
        {
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource = new object[][]
            {
                new object[]
                {
                    null,
                    "notnull",
                    "arg1"
                },

                new object[]
                {
                    "notnull",
                    null,
                    "arg2"
                },
            };

            [Theory]
            [MemberData(nameof(ThrowsArgumentNullExceptionAsyncTestSource))]
            public async Task ThrowsArgumentNullExceptionAsync(
                Mock<string> arg1,
                Mock<string> arg2,
                string expectedParameterNameForException)
            {
                var exception = await Assert.ThrowsAsync<ArgumentNullException>(() => Helper.ThrowIfNullAsync(
                    arg1.Object,
                    arg2.Object,
                    expectedParameterNameForException));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}
