namespace Basic2.Sources.BasicPractice;

public class HomeWorkBp
{
    public void Run()
    {
        HW1();
        HW2();
        HW3();
        HW4();
        HW5();
    }

    private void HW5()
    {
        Console.WriteLine("What's your first name?");
        string firstName = Console.ReadLine();

        Console.WriteLine("What's your last name?");
        string lastName = Console.ReadLine();

        Console.WriteLine("What's your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What's your weight in kg?");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("What's your height in meters");
        double height = double.Parse(Console.ReadLine());

        double bodyMassIndex = weight / (height * height);

        string profile = $"Your profile:{Environment.NewLine}"
                         + $"Full name: {firstName} {lastName}{Environment.NewLine}"
                         + $"Age: {age}{Environment.NewLine}"
                         + $"Weight: {weight}{Environment.NewLine}"
                         + $"Height: {height}{Environment.NewLine}"
                         + $"Body Mass Index: {bodyMassIndex:N2}";

        Console.WriteLine(profile);
    }

    private void HW4()
    {
        Console.WriteLine("Let's calculate the square of a triangle");

        Console.WriteLine("Enter the length if side AB:");
        double ab = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length if side BC:");
        double bc = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the length if side AC:");
        double ac = double.Parse(Console.ReadLine());

        double p = (ab + bc + ac) / 2;
        double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));

        Console.WriteLine($"Square of the triangle equals: {square:N2}");
    }

    private void HW3()
    {
        Console.WriteLine("Enter an integer");
        int number = int.Parse(Console.ReadLine());

        int numberOfDigits = number.ToString().Length;
        Console.WriteLine($"The number of digits: {numberOfDigits}");
    }

    private void HW2()
    {
        Console.WriteLine("Enter the first integer");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"a = {a}, b = {b}");

        (a, b) = (b, a);

        Console.WriteLine($"a = {a}, b = {b}");
    }

    private void HW1()
    {
        Console.WriteLine("What's your name?");

        string name = Console.ReadLine();

        Console.WriteLine($"Hello, {name}");
    }
}