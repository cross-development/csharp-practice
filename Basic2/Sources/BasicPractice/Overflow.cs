namespace Basic2.Sources.BasicPractice;

public class Overflow
{
    public void Run()
    {
        // Check if var is overflowed. This expression is too slow
        checked
        {
            uint x = uint.MaxValue;

            Console.WriteLine(x);

            x += 1; // Warning: Possible overflow in unchecked context

            Console.WriteLine(x);

            x -= 1;

            Console.WriteLine(x);
        }
    }
}