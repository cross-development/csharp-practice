namespace Practice.Cycles;

public class CyclesPractice
{
    public static void Run()
    {
        // цикл for
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Hello world!");
        }

        string[] letters = { "a", "b", "c", "d" };

        for (int i = 0; i < letters.Length; i++)
        {
            Console.WriteLine($"Letter: {letters[i]}");
        }

        int[] arr = { 1, 2, 3, 4, 5 };

        for (int i = 1; i < arr.Length - 1; i++)
        {
            Console.WriteLine($"{i} = {arr[i]}");
        }

        // цикл foreach
        string[] letters1 = { "a", "b", "c", "d" };

        foreach (string letter in letters1)
        {
            Console.WriteLine($"Letter: {letter}");
        }

        bool[] boolArr = { true, false, false, false };

        for (int i = boolArr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"Item {i}: {boolArr[i]}");
        }

        Array.Reverse<bool>(boolArr);

        foreach (bool item in boolArr)
        {
            Console.WriteLine($"Item: {item}");
        }

        // цикл while
        string[] letters2 = { "a", "b", "c", "d" };

        int index = 0;

        while (index < letters2.Length)
        {
            Console.WriteLine($"Letter: {letters2[index]}");
            index++;
        }

        int[] intArr = { 70, -24, 0, 11, 1 };

        int idx1 = 0;

        while (intArr[idx1] != 0 && idx1 <= intArr.Length)
        {
            Console.WriteLine($"Item: {intArr[idx1]}");
            idx1++;
        }

        // цикл do while
        int x = 5;

        do
        {
            Console.WriteLine($"Hello: {x}");
        } while (x == 0);
    }
}
