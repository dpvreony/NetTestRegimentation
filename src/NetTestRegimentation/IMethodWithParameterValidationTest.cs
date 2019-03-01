namespace NetTestRegimentation
{
    public interface IMethodWithParameterValidationTest<in TInput>
    {
        void ThrowsArgumentException(TInput input, string expectedParameterNameForException);
    }
}