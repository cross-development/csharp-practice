namespace csharp_practice.Sources.EventsPractice
{
    public class EventsBasic
    {
        public void Run()
        {
            Car car = new Car("Ford Focus", 10);

            // car.TankIsEmpty += new Car.TankChecker(car.HandleTankIsEmptyEvent1); // 4.3 подписка на событие (с использованием своего делегата)
            car.TankIsEmpty += new Action(car.HandleTankIsEmptyEvent1); // 4.3 подписка на событие (с использованием системных делегатов Action | Func)
            car.TankIsEmpty += HandleTankIsEmptyEvent2; // 4.3 подписка на событие

            car.Drive();
            car.Drive();
            car.Drive(); // 5. инициировать наступление события TankIsEmpty
        }

        // 4.2 метод-обработчик события TankIsEmpty во внешнем коде
        public void HandleTankIsEmptyEvent2()
        {
            Console.WriteLine("Вызываем эвакуатор...");
        }
    }
}
