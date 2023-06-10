namespace Basic2.Sources.BasicPractice;

public class ArrayBasic
{
    public void Run()
    {
        int[] a1;
        a1 = new int[10]; // each element is 0 by default

        int[] a2 = new int[5];

        int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

        int[] a4 = { 1, 3, 2, 4, 5 };

        Console.WriteLine(a4[0]); // 1

        int number = a4[4]; // 5
        Console.WriteLine(number);

        a4[4] = 6;
        Console.WriteLine(a4[4]); // 6

        Console.WriteLine(a4.Length);
        Console.WriteLine(a4[a4.Length - 1]);

        string s1 = "abcdefgh";
        char first = s1[0];
        Console.WriteLine(first);
        char last = s1[s1.Length - 1];
        Console.WriteLine(last);

        // s1[0] = 'z'; ==> Error: The indexer 'System.String.this[int]' has no setter
        
    }
}