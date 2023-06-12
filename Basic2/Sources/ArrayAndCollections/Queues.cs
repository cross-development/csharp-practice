namespace Basic2.Sources.ArrayAndCollections;

public class Queues
{
    public void Run()
    {
        /*
         * Abstract Data Type (ADT)
         * Implements FIFO - "First-In First-Out"
         * Operations:
         * - Enqueue - add an item to the end of the queue
         * - Dequeue - remove an item at the front of the queue
         * - Peek - get an item at the front of the queue without removing 
         */

        var queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        Console.WriteLine($"Should print out 1: {queue.Peek()}");

        queue.Dequeue();

        Console.WriteLine($"Should print out 2: {queue.Peek()}");

        Console.WriteLine("Iterate over the queue");

        foreach (int cur in queue)
        {
            Console.WriteLine(cur);
        }
    }
}