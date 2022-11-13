namespace csharp_practice.Sources.Inheritance
{
    public class Animal
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
    }
}
