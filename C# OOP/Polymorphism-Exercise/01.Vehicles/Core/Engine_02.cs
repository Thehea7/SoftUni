

using _01.Vehicles.Core.Models;
using _01.Vehicles.Factories.Interfaces;
using _01.Vehicles.IO.Interfaces;
using _01.Vehicles.Models;
using _01.Vehicles.Models.Interfaces;

namespace _01.Vehicles.Core
{
    internal class Engine_02 : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IVehicleFactory vehicleFactory;
        public Engine_02(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;
        }


        public void Run()
        {
            ICollection<IVehicle> vehicles = new List<IVehicle>();
           
            vehicles.Add(GetVehicle());
            vehicles.Add(GetVehicle());
            vehicles.Add(GetVehicle());

            int entries = int.Parse(reader.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                try
                {
                    ProcessCommands(vehicles);
                }
                catch (ArgumentNullException e)
                {
                    writer.WriteLine(e.Message);
                }
            }
            foreach (var vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }

        }

        private void ProcessCommands(ICollection<IVehicle> vehicles)
        {
            string[] input = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = input[0];
            string type = input[1];
            double amount = double.Parse(input[2]);
            IVehicle vehicle = vehicles.FirstOrDefault(x => x.GetType().Name == type);
            if (vehicle == null)
            {
                throw new ArgumentNullException("Such Vehicle does not exist");
            }

            try
            {
                if (command == "Drive")
                {
                    writer.WriteLine(vehicle.Drive(amount));
                }
                else if(command == "Refuel")
                {
                    try
                    {
                        vehicle.Refuel(amount);
                    }
                    catch (ArgumentException e)
                    {
                        writer.WriteLine(e.Message);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    writer.WriteLine((vehicle as Bus).DriveEmpty(amount));
                }
            }
            catch (ArgumentException e)
            {
                writer.WriteLine(e.Message);
            }
            
        }
        private IVehicle GetVehicle()
        {
            string[] vehicleInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            return vehicleFactory.Create(vehicleInfo);
        }
    }
}

