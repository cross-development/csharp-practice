namespace Basic2.Sources.OopPractice;

public class MethodsAndArgs
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3, 4 };

        // named args
        var result1 = Average(numbers: numbers);
        Console.WriteLine($"Average result_1 is {result1}");

        var result2 = Average2(1, 2, 3, 4);
        Console.WriteLine($"Average result_2 is {result2}");

        TryParseWithOut();

        if (TryDivide(10, 2, out double result3))
            Console.WriteLine(result3);
        else
            Console.WriteLine("Failed to divide");
    }

    public double Average(int[] numbers)
    {
        double sum = 0;

        foreach (var n in numbers)
        {
            sum += n;
        }

        return sum / numbers.Length;
    }

    /// <summary>
    /// Calculate an average value
    /// </summary>
    /// <param name="numbers">Some sequence of numbers. Key word "params" should be the last arg in the method</param>
    /// <returns>Average value</returns>
    public double Average2(params int[] numbers)
    {
        double sum = 0;

        foreach (var n in numbers)
        {
            sum += n;
        }

        return sum / numbers.Length;
    }

    public void TryParseWithOut()
    {
        Console.WriteLine("Enter a number, please.");

        string userInput = Console.ReadLine();
        bool wasParsed = int.TryParse(userInput, out int number);

        if (wasParsed)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine("Sorry");
        }
    }

    public bool TryDivide(double divisible, double divisor, out double result)
    {
        result = 0;

        if (divisor == 0)
        {
            return false;
        }

        result = divisible / divisor;

        return true;
    }
}