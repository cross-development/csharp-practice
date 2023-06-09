namespace csharp_practice.Sources.InterfaceInheritancePractice
{
    public class Employee : IDriver
    {
        public void DriveToPlace(string place)
        {
            Console.WriteLine($"Employee drives to place {place}");
        }

        public void FillUpCar(int litres)
        {
            Console.WriteLine($"Employee fill up his car by {litres} litres");
        }
    }

    public class Student : IDriver
    {
        public void DriveToPlace(string place)
        {
            Console.WriteLine($"Student drives to place {place}");
        }

        public void FillUpCar(int litres)
        {
            Console.WriteLine($"Student fill up his car by {litres} litres");
        }
    }

    public class SchoolBoy { }
}
