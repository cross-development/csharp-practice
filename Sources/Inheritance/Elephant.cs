namespace csharp_practice.Sources.Inheritance
{
    // классическое наследование (отношение "является")
    // запечатанный класс (нет возможности наследоваться от него)
    public sealed class Elephant : Animal
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
