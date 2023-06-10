namespace Basic2.Sources.BasicPractice;

public class Parsing
{
    public void Run()
    {
        ConsoleBasics();
        CastingAndParsing();
    }

    private void CastingAndParsing()
    {
        byte b = 3; // 0000 0011 (1 byte == 8 bits)
        int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011 
        long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011
        Console.WriteLine(l);

        float f = i; // 3.0
        Console.WriteLine(f);

        // b = i; ==> Error: Cannot convert source type 'int' to target type 'byte'
        b = (byte)i; // implicit cast
        Console.WriteLine(b);

        i = (int)f;
        Console.WriteLine(i);

        f = 3.1f;
        i = (int)f;
        Console.WriteLine(i); // 3

        string str = "1";
        // i = (int)str; ==> Error: Cannot cast expression of type 'string' to type 'int'
        i = int.Parse(str);
        Console.WriteLine(i);

        int x = 5;
        int result = x / 2;
        Console.WriteLine(result); // 2

        double result2 = (double)x / 2; // 5.0 / 2
        Console.WriteLine(result2); // 2.5
    }

    private void ConsoleBasics()
    {
        Console.WriteLine("Hy! Please, tell my your name");
        string name = Console.ReadLine();
        string answer1 = $"Your name is {name}";
        Console.WriteLine(answer1);

        Console.WriteLine("Now, please tell me your age");
        string input = Console.ReadLine();
        int age = int.Parse(input);

        string answer2 = $"Your age is {age}";
        Console.WriteLine(answer2);

        Console.Clear();
        Console.BackgroundColor = ConsoleColor.Black;
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("New Style ");
        Console.Write("New Style\n");
    }
}