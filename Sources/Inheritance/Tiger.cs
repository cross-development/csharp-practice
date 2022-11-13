namespace csharp_practice.Sources.Inheritance
{
    public class Tiger : Animal
    {
        public int TailLength { get; set; }

        public Tiger(string name, int age, double weight, int tailLength) : base(name, age, weight)
        {
            this.TailLength = tailLength;
        }
    }
}
