namespace Basic2.Sources.OopPractice;

public class MethodOverloading
{
    public void Run()
    {
        double square1 = CalcTriangleSquare(b: 40, h: 20);
        double square2 = CalcTriangleSquare(ab: 40, bc: 20, ac: 30);
        double square3 = CalcTriangleSquare(ab: 40, ac: 20, alpha: 50);

        Console.WriteLine($"Square 1 = {square1}");
        Console.WriteLine($"Square 2 = {square2}");
        Console.WriteLine($"Square 3 = {square3}");
    }

    public double CalcTriangleSquare(double ab, double bc, double ac)
    {
        double p = (ab + bc + ac) / 2;

        return Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
    }

    public double CalcTriangleSquare(double b, double h)
    {
        return 0.5 * b * h;
    }

    public double CalcTriangleSquare(double ab, double ac, int alpha)
    {
        double rads = alpha * Math.PI / 100;
        return 0.5 * ab * ac * Math.Sin(rads);
    }
}