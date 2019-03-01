using System.Threading.Tasks;

namespace NetTestRegimentation
{
    public interface IAsyncMethodWithNullableParametersTest<in TInput>
    {
        Task ThrowsArgumentNullExceptionAsync(TInput input, string expectedParameterNameForException);
    }
}