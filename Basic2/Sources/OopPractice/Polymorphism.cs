namespace Basic2.Sources.OopPractice;

public class Polymorphism
{
    public void Run()
    {
        Shape[] shapes = new Shape[2];
        shapes[0] = new Triangle(10, 20, 30);
        shapes[1] = new Rectangle(10, 20);

        foreach (Shape shape in shapes)
        {
            shape.Draw();
            Console.WriteLine(shape.Perimeter());
        }

        Console.ReadLine();
    }
}

internal abstract class Shape
{
    protected Shape()
    {
        Console.WriteLine("Shape created");
    }

    public abstract void Draw();

    public abstract double Area();

    public abstract double Perimeter();
}

internal class Triangle : Shape
{
    private readonly double ab;
    private readonly double bc;
    private readonly double ac;

    public Triangle(double ab, double bc, double ac)
    {
        this.ab = ab;
        this.bc = bc;
        this.ac = ac;

        Console.WriteLine("Triangle created");
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing triangle");
    }

    public override double Area()
    {
        double s = (ab + bc + ac) / 2;
        return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ac));
    }

    public override double Perimeter()
    {
        return ab + bc + ac;
    }
}

internal class Rectangle : Shape
{
    private readonly double width;
    private readonly double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;

        Console.WriteLine("Rectangle created");
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing rectangle");
    }

    public override double Area()
    {
        return width * height;
    }

    public override double Perimeter()
    {
        return 2 * (width + height);
    }
}