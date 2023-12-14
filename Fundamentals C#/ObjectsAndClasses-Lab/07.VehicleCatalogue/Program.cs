namespace _07.VehicleCatalogue
{

    class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Weight { get; set; }

    }
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog(List<Car> orderedCars, List<Truck> orderedTrucks)
        {
            Cars = orderedCars;
            Trucks = orderedTrucks;
        }

        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }
    }
    internal class Program
    {
        static void Main()
        {
            string command = string.Empty;
            
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split("/").ToArray();
                if (input[0] == "Car")
                {
                    AddCar(input, cars);
                }
                else if (input[0] == "Truck")
                {
                    AddTruck(input, trucks);
                }
            }
            List<Car> orderedCars = cars.OrderBy(car => car.Brand).ToList();
            List<Truck> orderedTrucks = trucks.OrderBy(x => x.Brand).ToList();
            Catalog catalog = new Catalog(orderedCars, orderedTrucks);
            PrintCatalog(catalog);
            
        }

        private static void PrintCatalog(Catalog catalog)
        {
            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in catalog.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in catalog.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }

            }
        }

        private static void AddTruck(string[] input, List<Truck> trucks)
        {
            Truck truck = new Truck();
            truck.Brand = input[1];
            truck.Model = input[2];
            truck.Weight = input[3];
            trucks.Add(truck);
        }

        private static void AddCar(string[] input, List<Car> cars)
        {
            Car car = new Car();
            car.Brand = input[1];
            car.Model = input[2];
            car.HorsePower = input[3];
            cars.Add(car);
        }
    }
}