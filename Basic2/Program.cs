using Basic2.Sources.BasicPractice;
using Basic2.Sources.ControlFlow;

namespace Basic2;

public static class Program
{
    static void Main(string[] args)
    {
        BasicPractice();
        ControlFlow();
    }

    private static void ControlFlow()
    {
        new Conditional().Run();
        new Cycles().Run();
        new SwitchCase().Run();
        new HomeWorkCf().Run();
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
        new HomeWorkBp().Run();
    }
}