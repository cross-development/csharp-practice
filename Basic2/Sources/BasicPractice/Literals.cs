namespace Basic2.Sources.BasicPractice;

public class Literals
{
    public void Run()
    {
        int x = 0b11;
        int y = 0b1001;
        int k = 0b10001001;
        int m = 0b1000_1001;

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(k);
        Console.WriteLine(m);
        Console.WriteLine();

        x = 0x1f;
        y = 0xff0d;
        k = 0x1fab30ef;
        m = 0x1fab_30ef;

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(k);
        Console.WriteLine(m);
        Console.WriteLine();

        Console.WriteLine(4.5e2); // 4.5 * 10 ^ 2
        Console.WriteLine(3.1e-1); // 3.1 * 10 ^ -1
        Console.WriteLine();

        Console.WriteLine('\x78'); // x
        Console.WriteLine('\x5A'); // Z
        Console.WriteLine('\u0420'); // P
        Console.WriteLine('\u0421'); // C
        Console.WriteLine();
    }
}