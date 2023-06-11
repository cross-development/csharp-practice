namespace Basic2.Sources.ControlFlow;

public class Cycles
{
    public void Run()
    {
        ForForeach();
        NestedFor();
        WhileDoWhile();
        BreakContinue();
    }

    private void BreakContinue()
    {
        int[] numbers1 = { 0, 3, 1, 2, 5, 4, 6, 7, 9, 8 };

        foreach (int n in numbers1)
        {
            if (n % 2 != 0)
            {
                continue;
            }

            Console.WriteLine(n);
        }

        Console.WriteLine();

        char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

        for (int i = 0; i < numbers1.Length; i++)
        {
            Console.WriteLine($"Number={numbers1[i]}");

            for (int j = 0; j < letters.Length; j++)
            {
                if (numbers1[i] == j)
                {
                    break;
                }

                Console.Write($" {letters[j]} ");
            }

            Console.WriteLine();
        }


        int[] numbers2 = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };
        int counter = 0;

        for (int i = 0; i < numbers2.Length - 1; i++)
        {
            if (counter == 3)
            {
                break;
            }

            for (int j = i + 1; j < numbers2.Length; j++)
            {
                int atI = numbers2[i];
                int atJ = numbers2[j];

                if (atI + atJ == 0)
                {
                    Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    counter++;
                }


                if (counter == 3)
                {
                    break;
                }
            }
        }
    }

    private void WhileDoWhile()
    {
        int age = 0;

        while (age < 18)
        {
            Console.WriteLine("While loop");
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Good!");

        do
        {
            Console.WriteLine("Do\\While loop");
            Console.WriteLine("What is your age?");
            age = int.Parse(Console.ReadLine());
        } while (age < 18);

        int[] numbers = { 1, 2, 3, 4, 5 };
        int i = 0;

        while (i < numbers.Length)
        {
            Console.WriteLine(numbers[i]);
            i++;
        }
    }

    private void NestedFor()
    {
        int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                int atI = numbers[i];
                int atJ = numbers[j];

                if (atI + atJ == 0)
                {
                    Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                }
            }
        }

        Console.WriteLine();

        for (int i = 0; i < numbers.Length - 2; i++)
        {
            for (int j = i + 1; j < numbers.Length - 1; j++)
            {
                for (int k = j + 1; k < numbers.Length; k++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];
                    int atK = numbers[k];

                    if (atI + atJ + atK == 0)
                    {
                        Console.WriteLine($"Triplets ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                    }
                }
            }
        }
    }

    private void ForForeach()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"{numbers[i]} ");
        }

        Console.WriteLine();

        for (int j = numbers.Length - 1; j >= 0; j--)
        {
            Console.Write($"{numbers[j]} ");
        }

        for (int k = 0; k < numbers.Length; k++)
        {
            if (numbers[k] % 2 == 0)
            {
                Console.Write($"{numbers[k]} ");
            }
        }

        foreach (int val in numbers)
        {
            Console.Write($"{val} ");
        }
    }
}