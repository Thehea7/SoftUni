using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            List<Tire[]> tireslist = new();
            List<Engine> engines = new();
            List<Car> cars = new();

            string command;

            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Tire[] tires = new Tire[4];
                for (int i = 0; i < 8; i+=2)
                {
                    int year = int.Parse(arguments[i]);
                    double pressure = double.Parse(arguments[i+1]);
                    tires[i/2] = new Tire(year, pressure);
                }
                tireslist.Add(tires);
            }

            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int horsepower = int.Parse(arguments[0]);
                double cubicCapacty = double.Parse(arguments[1]);

                engines.Add(new Engine(horsepower, cubicCapacty));
            }

            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] arguments = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string make = arguments[0];
                string model = arguments[1];
                int year = int.Parse(arguments[2]);
                double fuelQuantity = double.Parse(arguments[3]);
                double fuelConsumption = double.Parse(arguments[4]);
                int engineIndex = int.Parse(arguments[5]);
                int tiresIndex = int.Parse(arguments[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tireslist[tiresIndex]));
            }

            Func<Car, bool> predicate = CreateFilter();

            var Filteredlist = cars.Where(predicate);

            if (Filteredlist.Any())
            {
                foreach (var car in Filteredlist)
                {
                    car.Drive(20);
                    Console.WriteLine(car.WhoAmI());
                }
            }
        }

        private static double GetPressure(Tire[] tires)
        {
            double pressure = 0;
            foreach (var tire in tires)
            {
                pressure += tire.Pressure;
            }

            return pressure;
        }
        private static Func<Car, bool> CreateFilter()
        {

            return x => x.Year >= 2017 
                        && x.Engine.HorsePower > 330 
                        && GetPressure(x.Tires) > 9 
                        && GetPressure(x.Tires) < 10;
        }
    }
}
