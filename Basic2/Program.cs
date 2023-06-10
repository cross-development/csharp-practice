using Basic2.Sources.BasicPractice;

namespace Basic2;

public static class Program
{
    static void Main(string[] args)
    {
        BasicPractice();
    }

    private static void BasicPractice()
    {
        new Variables().Run();
        new Literals().Run();
        new Scope().Run();
        new Overflow().Run();
        new Arithmetic().Run();
        new Strings().Run();
        new Parsing().Run();
        new ArrayBasic().Run();
        new DateTimes().Run();
        new HomeWork().Run();
    }
}