namespace NetTestRegimentation
{
    public interface ITestEntityFrameworkDbSetProperty
    {
        void AllowsInsert();

        void PreventsDuplicateInsert();
    }
}