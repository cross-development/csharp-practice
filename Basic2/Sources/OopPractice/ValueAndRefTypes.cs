namespace Basic2.Sources.OopPractice;

public class ValueAndRefTypes
{
    public void Run()
    {
        PointVal a; // the same as PointVal a = new PointVal()
        a.X = 3;
        a.Y = 5;

        PointVal b = a;
        b.X = 7;
        b.Y = 10;

        a.LogValues(); // 3, 5
        b.LogValues(); // 7, 10

        Console.WriteLine("After structs");

        PointRef c = new PointRef();
        c.X = 3;
        c.Y = 5;

        PointRef d = c;
        d.X = 7;
        d.Y = 10;

        c.LogValues(); // 7, 10
        d.LogValues(); // 7, 10
    }
}

internal struct PointVal
{
    public int X;
    public int Y;

    public void LogValues()
    {
        Console.WriteLine($"X = {X}; Y = {Y}");
    }
}

internal class PointRef
{
    public int X;
    public int Y;

    public void LogValues()
    {
        Console.WriteLine($"X = {X}; Y = {Y}");
    }
}