using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometar { get; set; }
        public double TravelledDistance { get; set; } = 0;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometar)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometar = fuelConsumptionPerKilometar;
        }

        public void Drive(double kilometars)
        {
            if (FuelAmount < FuelConsumptionPerKilometar * kilometars)
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return;
            }

            TravelledDistance += kilometars;
            FuelAmount -= kilometars * FuelConsumptionPerKilometar;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TravelledDistance}";
        }
    }
}
