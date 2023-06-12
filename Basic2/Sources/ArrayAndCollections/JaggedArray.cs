namespace Basic2.Sources.ArrayAndCollections;

public class JaggedArray
{
    public void Run()
    {
        int[][] jaggedArr = new int[4][];
        jaggedArr[0] = new int[1];
        jaggedArr[1] = new int[3];
        jaggedArr[2] = new int[2];
        jaggedArr[3] = new int[4];

        Console.WriteLine("Enter the number for a jagged array.");

        for (int i = 0; i < jaggedArr.Length; i++)
        {
            for (int j = 0; j < jaggedArr[i].Length; j++)
            {
                string st = Console.ReadLine();
                jaggedArr[i][j] = int.Parse(st);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Printing the Elements");

        for (int i = 0; i < jaggedArr.Length; i++)
        {
            for (int j = 0; j < jaggedArr[i].Length; j++)
            {
                Console.WriteLine($"{jaggedArr[i][j]} ");
            }

            Console.WriteLine();
        }
    }
}