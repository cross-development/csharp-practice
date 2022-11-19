namespace csharp_practice.Sources.DelegatePractice
{
    public delegate int SimpleDelegate();

    public class MulticastDelegate
    {
        public static void Run()
        {
            SimpleDelegate sDelegate = Method1;
            sDelegate += Method2;
            sDelegate += Method3;

            int result = sDelegate(); // invoked with specific order: Method1, Method2, Method3
            Console.WriteLine($"Result is (the last result in delegate's list): {result}"); // return 3

            // sDelegate -= Method2; // remove Method2 from delegate's list
        }

        public static int Method1()
        {
            Console.WriteLine("Method 1");
            return 1;
        }

        public static int Method2()
        {
            Console.WriteLine("Method 2");
            return 2;
        }

        public static int Method3()
        {
            Console.WriteLine("Method 3");
            return 3;
        }
    }
}
