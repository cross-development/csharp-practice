namespace csharp_practice.Sources.Inheritance
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }

        public Animal(string name, int age, double weight)
        {
            this.Name = name;
            this.Age = age;
            this.Weight = weight;
        }

        // наследник может переопределить метод, а может и нет
        public virtual void Feed()
        {
            Console.WriteLine("Вы покормили животное.");
        }

        // объявление возможно только в абстрактном классе.
        // наследник обязан реализовать этот метод.
        public abstract void Move();
    }
}
