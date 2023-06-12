namespace Basic2.Sources.ArrayAndCollections;

public class Stacks
{
    public void Run()
    {
        /*
         * Abstract Data Type (ADT)
         * Implements LIFO = "Last-In First-Out"
         * Operations:
         * - Push - add item to the top
         * - Pop - remove the top item
         * - Peek - get the top item without removeing
         */

        var stack = new Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);

        Console.WriteLine($"Should print out 4: {stack.Peek()}");

        stack.Pop();

        Console.WriteLine($"Should print out 3: {stack.Peek()}");

        Console.WriteLine("Iterate over the stack");

        foreach (int cur in stack)
        {
            Console.WriteLine(cur);
        }
    }
}