namespace csharp_practice.Sources.DelegatePractice
{
    public class Car
    {
        public delegate double DriveDelegate(
            double distance,
            double fuelLevel,
            double fuelConsumption1Km
        );

        public string Name { get; set; }
        public double FuelLevel { get; set; }
        private double _FuelConsumption1Km { get; set; }

        public Car(string name, double fuelLevel, double fuelConsumption100Km)
        {
            Name = name;
            FuelLevel = fuelLevel;
            _FuelConsumption1Km = fuelConsumption100Km / 100 * 1;
        }

        public void Drive(double distance, DriveDelegate delegator)
        {
            FuelLevel = delegator(distance, FuelLevel, _FuelConsumption1Km);
        }
    }
}
