namespace Basic2.Sources.OopPractice;

public class Interfaces
{
    public void Run()
    {
        List<object> list = new List<object>() { 1, 2, 3 };
        IBaseCollection collection = new BaseList(4);
        collection.Add(1);
        collection.AddRange(list);
    }
}

public interface IBaseCollection
{
    void Add(object obj);
    void Remove(object obj);
}

public static class BaseCollectionExtension
{
    public static void AddRange(this IBaseCollection collection, IEnumerable<object> objects)
    {
        foreach (var item in objects)
        {
            collection.Add(item);
        }
    }
}

public class BaseList : IBaseCollection
{
    private object[] items;
    private int count = 0;

    public BaseList(int initialCapacity)
    {
        items = new object[initialCapacity];
    }

    public void Add(object obj)
    {
        items[count] = obj;
        count++;
    }

    public void Remove(object obj)
    {
        items[count] = null;
        count--;
    }
}