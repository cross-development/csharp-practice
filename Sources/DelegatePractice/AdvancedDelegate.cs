namespace csharp_practice.Sources.DelegatePractice
{
    public delegate void SimpleDelegate2();

    public class AdvancedDelegate
    {
        public static void Method1() { }

        public static void Method2(int x, double y, string message) { }

        public static int Method3()
        {
            return 0;
        }

        public static float Method4(int x, double y, string message)
        {
            return 0;
        }

        public static void Run()
        {
            SimpleDelegate2 simpleDelegate1 = new SimpleDelegate2(Method1); // or
            SimpleDelegate2 simpleDelegate2 = Method1;

            simpleDelegate1(); // or
            simpleDelegate2.Invoke();

            // system delegate Action, method must return void (without value)
            Action simpleDelegate3 = Method1;
            Action<int, double, string> simpleDelegate4 = Method2;

            // system delegate Func, method must return any value except void (int, double etc.)
            Func<int> simpleDelegate5 = Method3;
            // the last type in generic is the return type of method
            Func<int, double, string, float> simpleDelegate6 = Method4;
        }
    }
}
