namespace NetTestRegimentation
{
    public interface IMethodWithRangeParametersTest<in TInput>
    {
        void ThrowsArgumentOutOfRangeException(TInput input, string expectedParameterNameForException);
    }
}
