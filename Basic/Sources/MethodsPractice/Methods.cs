namespace Sources.Methods;

public class MethodsPractice
{
    public static void Run()
    {
        int a = 2;
        int b = 4;

        AddTwoNumbers(a, b);

        int result = DivideTwoNumbers(b, a);
        Console.WriteLine($"Result {result}");

        int maxValue = GetMaxValue(new int[] { 1, 20, 30 });
        Console.WriteLine($"Max value is {maxValue}");

        int lettersCount = GetLettersCount("qwe");
        Console.WriteLine($"Letters count: {lettersCount}");

        string analyzeResult = AnalyzeNumber(new Random().Next(-2, 2));
        Console.WriteLine($"Analyze result: {analyzeResult}");
    }

    public static void AddTwoNumbers(int a, int b)
    {
        int result = a + b;

        Console.WriteLine($"{a} + {b} = {result}");
    }

    public static int DivideTwoNumbers(int a, int b)
    {
        int result = a / b;

        Console.WriteLine($"{a} / {b} = {result}");

        return result;
    }

    public static string ConcatTwoStrings(string str1, string srt2)
    {
        string resultStr = str1 + srt2;

        Console.WriteLine($"Result string: {resultStr}");

        return resultStr;
    }

    public static int GetMaxValue(int[] arr)
    {
        // Array.Sort<int>(arr);
        // return arr[arr.Length - 1];

        return arr.Max();
    }

    // HW
    public static int GetLettersCount(string str) => str.Length;

    public static string AnalyzeNumber(int num)
    {
        if (num > 0)
            return "Число больше нуля";

        if (num < 0)
            return "Число меньше нуля";

        return "Число равное нулю";
    }
}
