namespace Basic2.Sources.OopPractice;

public class OptionalParams
{
    public void Run()
    {
        CalcTriangleSquare(10, 20, 30);
    }

    /*
     * 1. Optional params should be at the end of all params
     * 2. Value should be compile time constants (1, false, "string" etc.)
     * 3. Not all languages from .net platform support optional params
     * 4. Should recompile 2th part apps if they use our code with optional params
     */
    public double CalcTriangleSquare(double ab, double ac, int alpha, bool isInRadians = false)
    {
        if (isInRadians)
        {
            return 0.5 * ab * ac * Math.Sin(alpha);
        }
        else
        {
            double rads = alpha * Math.PI / 100;
            return 0.5 * ab * ac * Math.Sin(rads);
        }
    }
}