namespace Basic2.Sources.ArrayAndCollections;

public class Dictionaries
{
    public void Run()
    {
        var people = new Dictionary<int, string>();
        people.Add(1, "John");
        people.Add(2, "Bob");
        people.Add(3, "Alice");

        people = new Dictionary<int, string>()
        {
            { 1, "John" },
            { 2, "Alice" },
            { 3, "Bob" },
        };

        string name = people[1]; // access by key
        Console.WriteLine(name);

        Console.WriteLine("Iterating over keys");
        // Dictionary<int, string>.KeyCollection
        var keys = people.Keys;

        foreach (var k in keys)
        {
            Console.WriteLine($"Key = {k}");
        }

        Console.WriteLine("Iterating over keys");
        // Dictionary<int, string>.ValueCollection
        var values = people.Values;

        foreach (var v in values)
        {
            Console.WriteLine($"Value = {v}");
        }

        Console.WriteLine("Iterating over key=value pairs");
        // KeyValuePair<int, string> pair
        foreach (var pair in people)
        {
            Console.WriteLine($"Key={pair.Key}. Value={pair.Value}");
        }

        Console.WriteLine();

        Console.WriteLine($"Count={people.Count}");

        bool containsKey = people.ContainsKey(2);
        Console.WriteLine(containsKey);

        bool containsValue = people.ContainsValue("John");
        Console.WriteLine(containsValue);

        people.Remove(1);

        if (people.TryAdd(2, "Elias"))
        {
            Console.WriteLine("Added successfully");
        }
        else
        {
            Console.WriteLine("Fails to add using key 2");
        }

        if (people.TryGetValue(2, out string? val))
        {
            Console.WriteLine($"Key 2, Val={val}");
        }
        else
        {
            Console.WriteLine("Failed to get");
        }
        
        people.Clear();
    }
}