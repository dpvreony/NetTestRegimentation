using System.Threading.Tasks;

namespace Dhgms.NetContrib.Playground.Features.UnitTesting
{
    public interface IAsyncMethodWithNullableParametersTest<in TInput>
    {
        Task ThrowsArgumentNullExceptionAsync(TInput input, string expectedParameterNameForException);
    }
}