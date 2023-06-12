namespace Basic2.Sources.ArrayAndCollections;

public class Lists
{
    public void Run()
    {
        var intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
        intList.Add(7);

        int[] intArray = { 1, 8, 9 };
        intList.AddRange(intArray);

        if (intList.Remove(1))
        {
            // do something
        }

        intList.RemoveAt(0);

        intList.Reverse();

        intList.Contains(4);

        int min = intList.Min();
        int max = intList.Max();

        Console.WriteLine($"Min={min}, max={max}");

        int indexOf5 = intList.IndexOf(5);
        int lastIndexOf = intList.LastIndexOf(2);

        Console.WriteLine($"IndexOf={indexOf5}, lastIndexOf");

        for (int i = 0; i < intList.Count; i++)
        {
            Console.WriteLine($"{intList[i]}");
        }

        foreach (int item in intList)
        {
            Console.WriteLine($"{item}");
        }
    }
}