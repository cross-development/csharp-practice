namespace Basic2.Sources.BasicPractice;

public class Variables
{
    public void Run()
    {
        int x = -1;

        int y; // 0 by default
        y = 2;
        // Int32 x1 = -1;

        // uint z = -1; ==> Error: Cannot convert source type 'int' to target type 'uint'

        // float f = 1.1; ==> Error: Cannot convert source type 'double' to target type 'float'
        float f = 1.1f;

        double d = 1.1;

        int x2 = 0;
        int x3 = new int();

        var a = 1; // Int32
        var b = 1.2; // Double

        // Dictionary<int, string> dict = new Dictionary<int, string>();
        var dict = new Dictionary<int, string>();

        // var v; ==> Error: Implicitly-typed local variable must be initialized

        // decimal money = 3.0; ==> Error: Cannot convert source type 'double' to target type 'decimal'
        decimal money = 3.0m;

        char character = 'A';

        string name = "A";

        bool canDrive = true;
        bool canDraw = false;

        object obj1 = "12";

        Console.WriteLine(a);
        Console.WriteLine(name);
    }
}