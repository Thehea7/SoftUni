using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double AdditionalConsumption = 1.4;
        private double consumptionLitersPerKilometer;
        public Bus(double fuel, double consumptionLitersPerKilometer) : base(fuel, consumptionLitersPerKilometer)
        {
        }

        public Bus(double fuel, double consumptionLitersPerKilometer, double tankCapacity) : base(fuel, consumptionLitersPerKilometer, tankCapacity)
        {
        }
        public override double ConsumptionLitersPerKilometer
        {
            get => consumptionLitersPerKilometer;
            init => consumptionLitersPerKilometer = (value + AdditionalConsumption);
        }
        public string DriveEmpty(double distance)
        {
            double emptyConsumption = ConsumptionLitersPerKilometer - AdditionalConsumption;
            if (distance * emptyConsumption <= Fuel)
            {
                Fuel -= distance * emptyConsumption;
                return $"{GetType().Name} travelled {distance} km";
            }
            else
            {
                return $"{GetType().Name} needs refueling";
            }
        }
    }
}
