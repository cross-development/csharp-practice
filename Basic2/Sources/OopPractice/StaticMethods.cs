namespace Basic2.Sources.OopPractice;

public class StaticMethods
{
    // This field will be the same for every instance of this class
    public static int Speed = 10;

    public int Health { get; set; } = 10;

    public static void Run()
    {
        Console.WriteLine("Static method Run");

        AverageNumber(new int[] { 1, 2, 3, 4 });

        Console.WriteLine();
    }

    // We can get an access to any static methods and fields inside this class (and outside without instantiating).
    public static double AverageNumber(int[] numbers)
    {
        double sum = 0;

        foreach (var n in numbers)
        {
            sum += n;
        }

        return sum / numbers.Length;
    }

    // We can not get an access to any non-static methods inside current class. Only after instantiating this class.
    public int PrintSpeed()
    {
        return Speed;
    }

    public void IncreaseSpeed()
    {
        Speed += 10;
    }
}