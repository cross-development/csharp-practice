namespace csharp_practice.Sources.InterfaceInheritancePractice
{
    public class Worker : ISkilledDeveloper
    {
        public void DevelopConsoleApplication()
        {
            throw new NotImplementedException();
        }

        public void DevelopWebApplication()
        {
            throw new NotImplementedException();
        }
    }

    public interface IDeveloper
    {
        public void DevelopConsoleApplication();
    }

    public interface ISkilledDeveloper : IDeveloper
    {
        public void DevelopWebApplication();
    }
}
