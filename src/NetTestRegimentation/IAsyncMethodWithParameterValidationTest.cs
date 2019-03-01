using System.Threading.Tasks;

namespace NetTestRegimentation
{
    public interface IAsyncMethodWithParameterValidationTest<in TInput>
    {
        Task ThrowsArgumentExceptionAsync(TInput input, string expectedParameterNameForException);
    }
}