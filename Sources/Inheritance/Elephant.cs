namespace csharp_practice.Sources.Inheritance
{
    public class Elephant : Animal
    {
        public int TrunkLength { get; set; }

        public Elephant(string name, int age, double weight, int trunkLength)
            : base(name, age, weight)
        {
            this.TrunkLength = trunkLength;
        }

        public void Feed()
        {
            Console.WriteLine("Вы покормили слона. Слон доволен.");
        }
    }
}
