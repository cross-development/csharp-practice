namespace csharp_practice.Sources.DelegatePractice
{
    public class Delegates
    {
        public delegate void PrinterDelegate(string message);

        public static void Run()
        {
            PrinterDelegate printerDelegate = new PrinterDelegate(PrintMessage);
            printerDelegate.Invoke("Message1");
            printerDelegate("Message2");

            Test test = new Test();
            PrinterDelegate printerTestDelegate = new PrinterDelegate(test.DoSomething);
            printerTestDelegate("Message3");

            // ==============================
            Console.WriteLine(Environment.NewLine);

            Car car = new Car("Ford Focus", 5, 7);
            car.Drive(10, CarService.CalculateDistance);
            car.Drive(15, CarService.CalculateDistance);
            car.Drive(45, CarService.CalculateDistanceWind);
            car.Drive(50, CarService.CalculateDistanceWind);
        }

        public static void PrintMessage(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
    }

    class Test
    {
        public void DoSomething(string message)
        {
            Console.WriteLine($"Message length: {message.Length}");
        }
    }
}
