namespace NetTestRegimentation
{
    public interface IMethodWithNullableParametersTest<in TInput>
    {
        void ThrowsArgumentNullException(TInput input, string expectedParameterNameForException);
    }
}