namespace csharp_practice.Sources.InterfaceInheritancePractice
{
    public class InterfaceInheritance
    {
        public static void Run1()
        {
            // ISkilledDeveloper worker = new Worker(); // has both methods
            // IDeveloper worker = new Worker(); // has only one method
            Worker worker = new Worker();

            worker.DevelopConsoleApplication();
            worker.DevelopWebApplication();
        }

        public static void Run() { }
    }
}
