using Basic2.Sources.ArrayAndCollections;
using Basic2.Sources.BasicPractice;
using Basic2.Sources.ControlFlow;
using Basic2.Sources.OopPractice;

namespace Basic2;

public static class Program
{
    static void Main(string[] args)
    {
        BasicPractice();
        ControlFlow();
        Arrays();
        Oop();
    }

    private static void Oop()
    {
        new FirstClass().Run();
        new MethodOverloading().Run();
        new MethodsAndArgs().Run();
        StaticMethods.Run();
        new OptionalParams().Run();
        new ValueAndRefTypes().Run();
        new Constructors().Run();
        new Inheritance().Run();
        new Polymorphism().Run();
    }

    private static void Arrays()
    {
        new Arrays().Run();
        new Lists().Run();
        new Dictionaries().Run();
        new Queues().Run();
        new Stacks().Run();
        new JaggedArray().Run();
        new MultiArray().Run();
        new HomeWorkAc().Run();
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