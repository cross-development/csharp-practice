namespace csharp_practice.Sources.LambdaPractice
{
    public class Lambda
    {
        public delegate void MessageSender(); // выводит сообщение в консоль
        public delegate bool ZeroOperationHandler(int x, int y);

        public void Run()
        {
            MessageSender ms = PrintMessage;
            ms(); // выполняет обычный метод

            // MessageSender ms2 = delegate()
            // {
            //     Console.WriteLine("Это анонимный метод");
            // };

            MessageSender ms2 = () => Console.WriteLine("Это анонимное лямбда-выражение");
            ms2();

            // ZeroOperationHandler zh = delegate(int x, int y)
            // {
            //     return (x + y > 0) ? true : false;
            // };
            //
            // OR
            //
            // ZeroOperationHandler zh = (int x, int y) => x + y > 0;
            ZeroOperationHandler zh = (x, y) => x + y > 0;
            zh(5, 5);

            MessageHandlerMethod(PrintMessage);

            // MessageHandlerMethod(
            //     delegate()
            //     {
            //         Console.WriteLine("Анонимный инлайн метод");
            //     }
            // );
            MessageHandlerMethod(() => Console.WriteLine("Это анонимное лямбда-выражение"));

            Lion lion = new Lion("Mufasa");
            Employee employee = new Employee();

            // lion.IsHungry += employee.Feed;
            lion.IsHungry += (lion) => employee.Feed(lion);
            lion.Walk();

            // lion.IsHungry += delegate()
            // {
            //     Console.WriteLine("Лев голоден. Это анонимный метод");
            // };
            //
            // OR
            //
            // lion.IsHungry += () =>
            // {
            //     Console.WriteLine("Лев голоден.");
            //     Console.WriteLine("Это анонимное лямбда-выражение");
            // };
            //
            // OR
            //
            // lion.IsHungry += () => Console.WriteLine("Лев голоден. Это анонимное лямбда-выражение");
        }

        public void PrintMessage()
        {
            Console.WriteLine("Это обычный метод");
        }

        public void MessageHandlerMethod(MessageSender messageSender)
        {
            messageSender();
        }
    }
}
