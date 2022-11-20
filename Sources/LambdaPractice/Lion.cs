namespace csharp_practice.Sources.LambdaPractice
{
    public class Lion
    {
        public string Name { get; }
        public event Action<Lion> IsHungry;

        public Lion(string name)
        {
            Name = name;
        }

        public void Walk()
        {
            Console.WriteLine($"Лев {Name} гуляет...");

            Thread.Sleep(3000);

            Console.WriteLine($"Лев {Name} голоден...");

            // если на это событие подписан хотя бы один метод, вызываем его
            if (IsHungry != null)
            {
                IsHungry(this);
            }
        }
    }
}
