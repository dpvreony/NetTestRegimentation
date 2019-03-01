using System.Threading.Tasks;

namespace Dhgms.NetContrib.Playground.Features.UnitTesting
{
    public interface IAsyncMethodWithParameterValidationTest<in TInput>
    {
        Task ThrowsArgumentExceptionAsync(TInput input, string expectedParameterNameForException);
    }
}