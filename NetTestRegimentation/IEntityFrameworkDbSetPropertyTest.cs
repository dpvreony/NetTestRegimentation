namespace Dhgms.NetContrib.Playground.Features.UnitTesting
{
    public interface IEntityFrameworkDbSetPropertyTest
    {
        void AllowsInsert();

        void PreventsDuplicateInsert();
    }
}