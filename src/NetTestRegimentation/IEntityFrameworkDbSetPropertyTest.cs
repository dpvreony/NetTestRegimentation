namespace NetTestRegimentation
{
    public interface IEntityFrameworkDbSetPropertyTest
    {
        void AllowsInsert();

        void PreventsDuplicateInsert();
    }
}