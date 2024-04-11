
namespace _01.Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double AdditionalConsumption = 0.9;
        private double consumptionLitersPerKilometer;
        public Car(double fuel, double consumptionLitersPerKilometer) : base(fuel, consumptionLitersPerKilometer)
        {
        }
        public Car(double fuel, double consumptionLitersPerKilometer, double tankCapacity) : base(fuel, consumptionLitersPerKilometer,  tankCapacity)
        {
        }

        public override double ConsumptionLitersPerKilometer
        {
            get => consumptionLitersPerKilometer;
            init => consumptionLitersPerKilometer = (value + AdditionalConsumption);
        }
    }
}
