namespace Basic2.Sources.ControlFlow;

public class HomeWorkCf
{
    public void Run()
    {
        HW1();
        HW2();
        HW3();
        HW4();
        HW5();
    }

    private void HW5()
    {
        string password = "qwerty";
        string login = "johndoe";

        int tries = 1;

        while (tries <= 3)
        {
            Console.WriteLine("Enter login");
            string userLogin = Console.ReadLine();

            Console.WriteLine("Enter password");
            string userPassword = Console.ReadLine();

            if (userLogin == login && userPassword == password)
            {
                Console.WriteLine("Enter the system");
                break;
            }

            tries++;
        }

        if (tries == 4)
        {
            Console.WriteLine("You exceeded the number of available tries.");
        }
    }

    private void HW4()
    {
        Console.WriteLine("Enter n >= 0");

        int n = int.Parse(Console.ReadLine() ?? string.Empty);

        long factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine(factorial);
    }

    private void HW3()
    {
        int[] numbers = new int[10];

        int inputCount = 0;

        while (inputCount < 10)
        {
            int number = int.Parse(Console.ReadLine() ?? string.Empty);
            numbers[inputCount] = number;

            inputCount++;

            if (number == 0)
            {
                break;
            }
        }

        int sum = 0;
        int count = 0;

        foreach (int n in numbers)
        {
            if (n > 0 && n % 3 == 0)
            {
                sum += n;
                count++;
            }
        }

        double avarage = (double)sum / count;

        Console.WriteLine(avarage);
    }

    private void HW2()
    {
        Console.WriteLine("Enter the number of Fibonacci numbers you want to generate");

        int n = int.Parse(Console.ReadLine());

        int[] fibonacci = new int[n];

        int a0 = 0;
        int a1 = 1;

        fibonacci[0] = a0;
        fibonacci[1] = a1;

        for (int i = 2; i < n; i++)
        {
            int a = a0 + a1;
            fibonacci[i] = a;

            a0 = a1;
            a1 = a;
        }

        foreach (int cur in fibonacci)
        {
            Console.WriteLine(cur);
        }

        Console.WriteLine();
    }

    private void HW1()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int max = a > b ? a : b;

        Console.WriteLine(max);
    }
}