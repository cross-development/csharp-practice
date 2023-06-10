namespace Basic2.Sources.BasicPractice;

public class Scope
{
    public void Run()
    {
        var a = 1;

        {
            var b = 2;

            {
                var c = 3;

                Console.WriteLine(a); // 1
                Console.WriteLine(b); // 2
                Console.WriteLine(c); // 3
            }

            Console.WriteLine(a); // 1
            Console.WriteLine(b); // 2
            // Console.WriteLine(c); ==> Error: Cannot resolve symbol 'c'  
        }

        Console.WriteLine(a); // 1
        // Console.WriteLine(b); ==> Error: Cannot resolve symbol 'b'
        // Console.WriteLine(c); ==> Error: Cannot resolve symbol 'c'
    }
}