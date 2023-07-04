namespace Basic2.Sources.OopPractice;

public class EvilInheritance
{
    public void Run()
    {
        // Rect rect = new Rect { Height = 2, Width = 5 };
        // int rectArea = AreaCalculator.CalcSquare(rect);
        // Console.WriteLine($"Rect area = {rectArea}");
        //
        // Rect square = new Square { Height = 2, Width = 10 };
        // int squareArea = AreaCalculator.CalcSquare(square);
        // Console.WriteLine($"Square area (wrong) = {squareArea}");

        IShape rect = new Rect { Height = 2, Width = 5 };
        IShape square = new Square { SideLength = 10 };

        Console.WriteLine($"Rect area = {rect.CalcSquare()}");
        Console.WriteLine($"Square area = {square.CalcSquare()}");
    }
}

public interface IShape
{
    int CalcSquare();
}

public class Rect : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int CalcSquare()
    {
        return Height * Width;
    }
}

public class Square : IShape
{
    public int SideLength { get; set; }

    public int CalcSquare()
    {
        return SideLength * SideLength;
    }
}

// public static class AreaCalculator
// {
//     public static int CalcSquare(Square square)
//     {
//         return square.Height * square.Height;
//     }
//
//     public static int CalcSquare(Rect rect)
//     {
//         return rect.Height * rect.Width;
//     }
// }