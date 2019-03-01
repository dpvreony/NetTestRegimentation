using System.Threading.Tasks;

namespace Dhgms.NetContrib.Playground.Features.UnitTesting
{
    public interface IAsyncMethodWithRangeParametersTest<in TInput>
    {
        Task ThrowsArgumentOutOfRangeExceptionAsync(TInput input, string expectedParameterNameForException);
    }
}