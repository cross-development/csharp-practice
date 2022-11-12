namespace Practice.Arrays;

public class ArrayPractice
{
    public static void Run()
    {
        int[] intArr = new int[5];
        intArr[0] = 2;
        intArr[1] = 4;
        intArr[2] = 6;
        intArr[3] = 8;
        intArr[4] = 10;

        string[] strArr = { "qwe", "asd", "zxc" };

        Console.WriteLine(strArr[0]);

        int[] numbers = { 3, 2, 4 };
        Console.WriteLine(numbers[0] + " " + numbers[1] + " " + numbers[2]);

        Console.WriteLine($"Количество элементов: {numbers.Length}");

        Array.Reverse<int>(numbers);
        Console.WriteLine($"Reversed array: {numbers}"); // { 4, 2, 3 }

        Array.Sort<int>(numbers);
        Console.WriteLine($"Sorted array: {numbers}"); // { 2, 3, 4 }

        Array.Clear(numbers, 0, numbers.Length);
        Console.WriteLine($"Cleared array: {numbers}"); // { 0, 0, 0 }

        string[] strings = new string[3];
        int idx = 0;

        Console.WriteLine("Введите три любых слова:");

        strings[idx++] = Console.ReadLine();
        strings[idx++] = Console.ReadLine();
        strings[idx] = Console.ReadLine();

        Console.WriteLine($"{strings[idx--]} {strings[idx--]} {strings[idx]}");

        Array.Reverse(numbers);
        Console.WriteLine(numbers);
    }
}
