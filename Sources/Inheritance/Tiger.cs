namespace csharp_practice.Sources.Inheritance
{
    // классическое наследование (отношение "является")
    public class Tiger : Animal
    {
        public int TailLength { get; set; }

        public Tiger(string name, int age, double weight, int tailLength) : base(name, age, weight)
        {
            this.TailLength = tailLength;
        }

        public override void Feed()
        {
            // get logic from parent method
            base.Feed();

            Console.WriteLine("Тигра кормим мясом.");
        }
    }
}
