namespace csharp_practice.Sources.Inheritance
{
    public class ClassicInheritance
    {
        public static void Run()
        {
            Tiger tiger = new Tiger("Tiger", 12, 50, 20);

            Elephant elephant = new Elephant("Elephant", 22, 300, 150);
            elephant.Feed();

            Office office = new Office();
            office.Number = 20;
            office.Comp.SerialNumber = 111;

            office.Comp.TurnOn();
        }
    }
}
