namespace Basic2.Sources.BasicPractice;

public class DateTimes
{
    public void Run()
    {
        DateTime now = DateTime.Now;
        Console.WriteLine(now.ToString());

        Console.WriteLine($"It is {now.Date}, {now.Hour}:{now.Minute}");

        DateTime dt = new DateTime(2022, 2, 24);

        DateTime newDt = dt.AddDays(1); // does not mutate the original instance "dt"
        Console.WriteLine(newDt.ToString());

        TimeSpan ts = now - dt; // call Subtract
        // ts = now.Subtract(dt);
        Console.WriteLine(ts.Days); // difference between two dates
    }
}