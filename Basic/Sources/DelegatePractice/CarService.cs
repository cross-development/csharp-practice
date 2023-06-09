namespace csharp_practice.Sources.DelegatePractice
{
    public static class CarService
    {
        public static double CalculateDistance(
            double distance,
            double fuelLevel,
            double fuelConsumption1Km
        )
        {
            fuelLevel -= distance * fuelConsumption1Km;

            if (fuelLevel <= 0)
            {
                Console.WriteLine($"Машина заглохла и не смогла проехать {distance} км.");
            }
            else
            {
                Console.WriteLine(
                    $"Пройдена дистанция: {distance} км. Осталось топлива в баке {fuelLevel} л."
                );
            }

            return fuelLevel;
        }

        public static double CalculateDistanceWind(
            double distance,
            double fuelLevel,
            double fuelConsumption1Km
        )
        {
            fuelLevel -= distance * fuelConsumption1Km;
            fuelLevel -= 0.2; // поправка на ветер

            if (fuelLevel <= 0)
            {
                Console.WriteLine($"Машина заглохла и не смогла проехать {distance} км.");
            }
            else
            {
                Console.WriteLine(
                    $"Пройдена дистанция: {distance} км. Осталось топлива в баке {fuelLevel} л."
                );
            }

            return fuelLevel;
        }
    }
}
