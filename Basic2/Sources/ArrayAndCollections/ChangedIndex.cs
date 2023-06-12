namespace Basic2.Sources.ArrayAndCollections;

public class ChangedIndex
{
    public void Run()
    {
        Array myArray = Array.CreateInstance(typeof(int), new[] { 4 }, new[] { 1 });
        myArray.SetValue(2019.ToString(), 1);
        myArray.SetValue(2020.ToString(), 2);
        myArray.SetValue(2021.ToString(), 3);
        myArray.SetValue(2022.ToString(), 4);

        Console.WriteLine($"Starting index: {myArray.GetLowerBound(0)}");
        Console.WriteLine($"Ending index: {myArray.GetUpperBound(0)}");

        for (int i = myArray.GetLowerBound(0); i <= myArray.GetUpperBound(0); i++)
        {
            Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
        }

        Console.WriteLine("Code above is the same as below");

        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine($"{myArray.GetValue(i)} at index {i}");
        }
    }
}