namespace csharp_practice.Sources.Inheritance
{
    public class ClassicInheritance
    {
        public static void Run()
        {
            // Office office = new Office();
            // office.Number = 20;
            // office.Comp.SerialNumber = 111;
            // office.Comp.TurnOn();

            Tiger tiger = new Tiger("Tiger", 12, 50, 20);
            Elephant elephant = new Elephant("Elephant", 22, 300, 150);

            tiger.Feed();
            elephant.Feed();

            Animal[] animals = {new Tiger("Tiger", 12, 50, 20), new Elephant("Elephant", 22, 300, 150)};

            foreach (Animal animal in animals)
            {
                animal.Feed();
                animal.Move();
            }

            // невозможно создавать экземпляры из абстрактных классов
            // Animal animal = new Animal();
        }
    }
}
