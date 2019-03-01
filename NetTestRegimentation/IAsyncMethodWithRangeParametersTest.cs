using System.Threading.Tasks;

namespace NetTestRegimentation
{
    public interface IAsyncMethodWithRangeParametersTest<in TInput>
    {
        Task ThrowsArgumentOutOfRangeExceptionAsync(TInput input, string expectedParameterNameForException);
    }
}