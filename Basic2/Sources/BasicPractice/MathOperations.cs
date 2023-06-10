namespace Basic2.Sources.BasicPractice;

public class MathOperations
{
    public void Run()
    {
        Console.WriteLine(Math.Pow(2, 3)); // 8
        Console.WriteLine(Math.Sqrt(9)); // 3

        Console.WriteLine(Math.Round(1.7)); // 2
        Console.WriteLine(Math.Round(1.4)); // 1

        Console.WriteLine(Math.Round(2.5)); // 2
        Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); // 3
        Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); // 2 ==> default usage (esp for bank systems)
    }
}