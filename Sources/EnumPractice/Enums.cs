namespace csharp_practice.Sources.EnumPractice
{
    public class Enums
    {
        public static void Run( )
        {
            Seasons season = Seasons.Autumn;
            DaysOfWeek day = DaysOfWeek.Friday;

            Seasons[] arr1 = { Seasons.Autumn, Seasons.Summer };
            
            List<DaysOfWeek> list = new List<DaysOfWeek>();
            list.Add(day);

            Console.WriteLine(season); // Autumn
            Console.WriteLine((int)season); // 3

            Console.WriteLine(day); // Friday
            Console.WriteLine((int)day); // 4
        }

        public static void CheckDayOff(DaysOfWeek days)
        {
            switch (days)
            {
                case DaysOfWeek.Saturday:
                    Console.WriteLine("Сегодня выходной");
                    break;
                case DaysOfWeek.Sunday:
                    Console.WriteLine("Сегодня выходной");
                    break;    
                default:
                    Console.WriteLine("Сегодня рабочий день");
                    break;
            }
        }
    }

    public enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Seasons
    {
        Winter,
        Spring,
        Summer,
        Autumn
    }
}