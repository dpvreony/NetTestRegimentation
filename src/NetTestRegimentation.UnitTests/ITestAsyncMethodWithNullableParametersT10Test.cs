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
            public static IEnumerable<object[]> ThrowsArgumentNullExceptionAsyncTestSource = ObjectArrayHelper.GetMoqArgObjectArrayOfArray(10);

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
                    arg1.Object,
                    arg2.Object,
                    arg3.Object,
                    arg4.Object,
                    arg5.Object,
                    arg6.Object,
                    arg7.Object,
                    arg8.Object,
                    arg9.Object,
                    arg10.Object,
                    expectedParameterNameForException));
                Assert.Equal(expectedParameterNameForException, exception.ParamName);
            }
        }
    }
}