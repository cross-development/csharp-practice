namespace Basic2.Sources.ArrayAndCollections;

public class HomeWorkAc
{
    private static Dictionary<char, int> map = new()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    public void Run()
    {
        HW1();
    }

    private void HW1()
    {
        int result = Parse("XIV");
        Console.WriteLine(result);
    }

    private int Parse(string roman)
    {
        int result = 0;

        for (int i = 0; i < roman.Length; i++)
        {
            if (i + 1 < roman.Length && IsSubtractive(roman[i], roman[i + 1]))
            {
                result -= map[roman[i]];
            }
            else
            {
                result += map[roman[i]];
            }
        }

        return result;
    }

    private bool IsSubtractive(char c1, char c2)
    {
        return map[c1] < map[c2];
    }
}