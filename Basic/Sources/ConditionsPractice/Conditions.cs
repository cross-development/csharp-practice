namespace Sources.Conditions;

public class ConditionsPractice
{
    public static void Run()
    {
        // условная конструкция if/else
        Random rand = new Random();
        int x = rand.Next(-2, 2);

        if (x > 0)
        {
            Console.WriteLine($"x > 0: {x}");
        }
        else if (x == 0)
        {
            Console.WriteLine($"x == 0: {x}");
        }
        else
        {
            Console.WriteLine($"x < 0: {x}");
        }

        // HW
        Console.Clear();

        Console.WriteLine("Желаете пройти проверку антивирусом? Введите да или нет");
        string answer = Console.ReadLine()!;

        if (answer.ToLower() == "да")
        {
            Console.WriteLine("Проводится проверка антивирусом...");
        }
        else
        {
            Console.WriteLine("Очень плохо, что вы отказались от этой процедуры.");
        }

        // условная конструкция switch
        int y = 1;

        switch (y)
        {
            case 1:
                Console.WriteLine($"Вы выбрали пункт меню {y}");
                break;

            case 2:
                Console.WriteLine($"Вы выбрали пункт меню {y}");
                break;

            default:
                Console.WriteLine($"Такого пункта меню нет");
                break;
        }

        // HW
        Console.Clear();

        Console.WriteLine("Желаете пройти проверку антивирусом? Введите да или нет");
        string answer1 = Console.ReadLine()!;

        switch (answer1.ToLower())
        {
            case "да":
                Console.WriteLine("Проводится проверка антивирусом...");
                break;

            case "нет":
                Console.WriteLine("Очень плохо, что вы отказались от этой процедуры.");
                break;

            default:
                Console.WriteLine("Такого действия нет");
                break;
        }
    }
}
