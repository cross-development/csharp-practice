namespace Basic2.Sources.ArrayAndCollections;

public class MultiArray
{
    public void Run()
    {
        int[,] r1 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        int[,] r2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        for (int i = 0; i < r2.GetLength(0); i++)
        {
            for (int j = 0; j < r2.GetLength(1); j++)
            {
                Console.Write($"{r2[i, j]} ");
            }

            Console.WriteLine();
        }
    }
}