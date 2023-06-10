namespace Basic2.Sources.BasicPractice;

public class Arithmetic
{
    public void Run()
    {
        IncrementDecrementDemo();
        MathOperations();
        ComparisonOperators();
    }

    private void IncrementDecrementDemo()
    {
        int x = 1;
        x = x + 1;

        Console.WriteLine(x);

        // increment by 1
        x++; // postfix
        Console.WriteLine(x);

        ++x; // suffix
        Console.WriteLine(x);

        x = x - 1;

        // decrement
        x--; // postfix
        Console.WriteLine(x);

        --x; // suffix
        Console.WriteLine(x);

        Console.WriteLine("Learn about increments");
        Console.WriteLine($"Last x state is {x}");

        int j = x++;
        Console.WriteLine(j);
        Console.WriteLine(x);

        j = ++x;
        Console.WriteLine(j);
        Console.WriteLine(x);

        x += 2;
        // x = x + 2;
        Console.WriteLine(x);
    }

    private void MathOperations()
    {
        int x = 1;
        int y = 2;

        int z = x + y;
        int k = x - y;
        int a = z + k - y;

        Console.WriteLine(z);
        Console.WriteLine(k);
        Console.WriteLine(a);

        int b = z * 2;
        int c = k / 2; // 0 because of the int behavior

        a = 4 % 2;
        b = 5 % 2;

        Console.WriteLine(a); // 0
        Console.WriteLine(b); // 1

        a = 3;
        a = a * a;
        a = a * a * a;

        a = 2 + 2 * 2;
        Console.WriteLine(a);

        a = (2 + 2) * 2;
        Console.WriteLine(a);

        a *= 2;
        Console.WriteLine(a);

        a /= 2;
        Console.WriteLine(a);
    }

    private void ComparisonOperators()
    {
        int x = 1;
        int y = 2;

        bool result;

        result = x == y;
        Console.WriteLine(result); // false

        result = x > y;
        Console.WriteLine(result); // false

        result = x >= y;
        Console.WriteLine(result); // false

        result = x < y;
        Console.WriteLine(result); // true

        result = x <= y;
        Console.WriteLine(result); // true

        result = x != y;
        Console.WriteLine(result); // true
    }
}