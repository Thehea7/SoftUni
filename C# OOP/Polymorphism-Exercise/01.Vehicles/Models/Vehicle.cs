
using _01.Vehicles.Models.Interfaces;

namespace _01.Vehicles.Models
{
    public abstract class Vehicle : IVehicle
    {
        private double consumptionLitersPerKilometer;
        private double tankCapacity;
        protected Vehicle(double fuel, double consumptionLitersPerKilometer)
        {
            Fuel = fuel;
            ConsumptionLitersPerKilometer = consumptionLitersPerKilometer;
            TankCapacity = int.MaxValue;
        }
        protected Vehicle(double fuel, double consumptionLitersPerKilometer, double tankCapacity)
        {
            Fuel = fuel;
            ConsumptionLitersPerKilometer = consumptionLitersPerKilometer;
            TankCapacity = tankCapacity;
        }

        public double TankCapacity
        {
            get => tankCapacity;
            init
            {
                if (Fuel > value)
                {
                    Fuel = 0;
                }
                tankCapacity = value;
            }
        }

        public double Fuel { get; protected set; }

        public virtual double ConsumptionLitersPerKilometer { get => consumptionLitersPerKilometer; init => consumptionLitersPerKilometer = value; }

        public virtual string Drive(double distance)
        {
            if (distance * ConsumptionLitersPerKilometer <= Fuel)
            {
                Fuel -= distance * ConsumptionLitersPerKilometer;
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }

        }

        public virtual void Refuel(double liters)
        {
            if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            if (Fuel + liters > TankCapacity)
            {
                throw new ArgumentException($"Cannot fit {liters} fuel in the tank");
            }
            Fuel += liters;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Fuel:f2}";
        }
    }
}
