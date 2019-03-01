namespace Dhgms.NetContrib.Playground.Features.UnitTesting
{
    public interface IMethodWithParameterValidationTest<in TInput>
    {
        void ThrowsArgumentException(TInput input, string expectedParameterNameForException);
    }
}