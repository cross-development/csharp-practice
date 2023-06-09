namespace csharp_practice.Sources.EventsPractice
{
    public class Car
    {
        // public delegate void TankChecker(); // 1. делегат, который используется для поддержки события или используем системный делегат Action | Func
        public event Action TankIsEmpty; // 2. объявляем событие "бак пустой", которое привязано к делегату

        public string Model { get; set; }
        public double FuelLevel { get; set; }

        public Car(string model, double fuelLevel)
        {
            Model = model;
            FuelLevel = fuelLevel;
        }

        public void Drive()
        {
            // 3. условие для возникновения события TankIsEmpty
            if (FuelLevel <= 0)
            {
                TankIsEmpty(); // событие произошло
            }
            else
            {
                FuelLevel -= 5;
                Console.WriteLine($"Автомобиль {Model} проехал дистанцию.");
            }
        }

        // 4.1 метод-обработчик события TankIsEmpty во внутреннем коде
        public void HandleTankIsEmptyEvent1()
        {
            Console.WriteLine("Бак пустой, машина дальше не едет");
        }
    }
}
