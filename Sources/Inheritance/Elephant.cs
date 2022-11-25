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

        public override void Feed()
        {
            base.Feed();

            Console.WriteLine("Слона кормим бананами.");
        }

        public override void Move()
        {
            Console.WriteLine("Тигр начинает бежать.");
        }
    }
}
