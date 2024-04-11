using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01.Vehicles.Factories.Interfaces;
using _01.Vehicles.Models;
using _01.Vehicles.Models.Interfaces;

namespace _01.Vehicles.Factories
{
    public class VehicleFactory_02 : IVehicleFactory
    {
        public IVehicle Create(string[] vehicleInfo)
        {
            string type = vehicleInfo[0];
            double fuel = double.Parse(vehicleInfo[1]);
            double consumption = double.Parse(vehicleInfo[2]);
            double tankCapacity = double.Parse(vehicleInfo[3]);

            switch (type)
            {
                case "Car":
                    return new Car(fuel, consumption, tankCapacity);
                case "Truck":
                    return new Truck(fuel, consumption, tankCapacity);
                case "Bus":
                    return new Bus(fuel, consumption, tankCapacity);
                default:
                    throw new ArgumentException("Unknown Type of Vehicle");
            }
        }
    }
}
