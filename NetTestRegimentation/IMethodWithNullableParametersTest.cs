namespace Dhgms.NetContrib.Playground.Features.UnitTesting
{
    public interface IMethodWithNullableParametersTest<in TInput>
    {
        void ThrowsArgumentNullException(TInput input, string expectedParameterNameForException);
    }
}