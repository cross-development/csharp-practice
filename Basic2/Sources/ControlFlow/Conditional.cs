namespace Basic2.Sources.ControlFlow;

public class Conditional
{
    public void Run()
    {
        Console.WriteLine("What's your age?");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("What's your weight in kg?");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("What's your height in meters");
        double height = double.Parse(Console.ReadLine());

        double bodyMassIndex = weight / (height * height);

        bool isTooLow = bodyMassIndex <= 18.5;
        bool isNormal = bodyMassIndex > 18.5 && bodyMassIndex < 25;
        bool isAboveNormal = bodyMassIndex >= 25 && bodyMassIndex <= 30;
        bool isTooFat = bodyMassIndex > 30;

        bool isFat = isAboveNormal || isTooFat;

        if (isFat)
        {
            Console.WriteLine("You'd better lose some weight.");
        }
        else
        {
            Console.WriteLine("You're in a good shape.");
        }

        if (!isFat)
        {
            Console.WriteLine("You are definitely not fat.");
        }

        if (isTooLow)
        {
            Console.WriteLine("Not enough weight");
        }
        else if (isNormal)
        {
            Console.WriteLine("You are ok.");
        }
        else if (isAboveNormal)
        {
            Console.WriteLine("Be careful");
        }
        else
        {
            Console.WriteLine("You need to lose some weight.");
        }

        if (isFat || isTooFat)
        {
            Console.WriteLine("Anyway it is time to get on diet");
        }

        string description = age > 18 ? "You can drink alcohol" : "You should get a bit older";
        Console.WriteLine(description);
    }
}