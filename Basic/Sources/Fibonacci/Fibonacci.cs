namespace csharp_practice.Sources.Fibonacci
{
    public static class Fibonacci
    {
        public static int Calculate(int number)
        {
            int n1 = 0;
            int n2 = 1;
            int sum;

            for (int i = 2; i < number; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }

            return number == 0 ? n1 : n2;
        }
    }
}
