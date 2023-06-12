namespace Basic2.Sources.ArrayAndCollections;

public class Arrays
{
    public void Run()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int index = Array.BinarySearch(numbers, 7); // it's better to use BinarySearch only on an ordered list
        Console.WriteLine(index);

        int number = numbers[0]; // access by index

        int[] copy = new int[10];
        Array.Copy(numbers, copy, numbers.Length);

        int[] anotherCopy = new int[10];
        copy.CopyTo(anotherCopy, 0);

        Array.Reverse(copy);
        foreach (int c in copy)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine();
        
        Array.Sort(copy);        
        foreach (int c in copy)
        {
            Console.WriteLine(c);
        }

        Console.WriteLine();
        
        Array.Clear(copy, 0, copy.Length);

        int[] a1;
        a1 = new int[10];

        int[] a2 = new int[5];

        int[] a3 = new int[5] { 1, 2, 3, 4, 5 };

        int[] a4 = { 1, 2, 3, 4, 5 };

        Array myArray = new int[5];

        // Array myArray2 = Array.CreateInstance(typeof(int), 5);
        // myArray2.SetValue(12, 0);
        // Console.WriteLine(myArray2.GetValue(0));
    }
}