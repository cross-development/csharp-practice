namespace csharp_practice.Sources.Inheritance
{
    // наследование через включение
    public class Office
    {
        public class Computer
        {
            public int SerialNumber { get; set; }

            public void TurnOn()
            {
                Console.WriteLine("Computer was turned on");
            }
        }

        public int Number { get; set; }
        public Computer Comp { get; set; }
        
        public Office()
        {
            this.Comp = new Computer();
        }
    }
}