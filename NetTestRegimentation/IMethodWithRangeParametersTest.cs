namespace Dhgms.NetContrib.Playground.Features.UnitTesting
{
    public interface IMethodWithRangeParametersTest<in TInput>
    {
        void ThrowsArgumentOutOfRangeException(TInput input, string expectedParameterNameForException);
    }
}
