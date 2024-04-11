
namespace _01.Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double AdditionalConsumption = 1.6;
        private const double ReFuelLoss = 0.95;//5% loss
        private double consumptionLitersPerKilometer;
        public Truck(double fuel, double consumptionLitersPerKilometer) : base(fuel, consumptionLitersPerKilometer)
        {
        }
        public Truck(double fuel, double consumptionLitersPerKilometer, double tankCapacity) : base(fuel, consumptionLitersPerKilometer, tankCapacity)
        {
        }

        public override double ConsumptionLitersPerKilometer
        {
            get => consumptionLitersPerKilometer;
            init => consumptionLitersPerKilometer = (value + AdditionalConsumption);
        }

        public override void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (Fuel + liters * ReFuelLoss > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            Fuel += liters * ReFuelLoss;
        }
    }
}
