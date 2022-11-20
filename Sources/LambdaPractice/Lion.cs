namespace csharp_practice.Sources.LambdaPractice
{
    public class Lion
    {
        public event Action IsHungry;

        public void Walk()
        {
            Console.WriteLine($"Лев гуляет.");

            if (IsHungry != null) // если на это событие подписан хотя бы один метод, вызываем его
            {
                IsHungry();
            }
        }
    }
}
