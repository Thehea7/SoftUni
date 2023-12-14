namespace _06.VehicleCatalogue
{
    class Vehicule
    {
        public Vehicule(string argument, string argument1, string argument2, int horsePower)
        {
            Type = argument;
            Model = argument1;
            Color = argument2;
            Horsepower = horsePower;
        }

        public string Type { get; set; }
        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

        public override string ToString()
        {
            return $"Type: {ToFirstCharUpper(Type)}\n" +
                   $"Model: {Model}\n" +
                   $"Color: {Color}\n" +
                   $"Horsepower: {Horsepower}";
        }

        public string ToFirstCharUpper(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return string.Empty;
            }
            return $"{input[0].ToString().ToUpper()}{input.Substring(1)}";
        }
    }

    internal class Program
    {
        static void Main()
        {
            string command = string.Empty;

            List<Vehicule> vehicules = new List<Vehicule>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                int horsePower = int.Parse(arguments[3]);

                Vehicule vehicule = new Vehicule(arguments[0], arguments[1], arguments[2], horsePower);

                vehicules.Add(vehicule);
            }

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicule currentVehicule = vehicules.Find(x => x.Model == input);
                Console.WriteLine(currentVehicule);

            }

            Console.WriteLine($"Cars have average horsepower of: {GetAverageCarHP(vehicules):f2}.");

            Console.WriteLine($"Trucks have average horsepower of: {GetAverageTruckHP(vehicules):f2}.");


        }

        private static double GetAverageCarHP(List<Vehicule> vehicules)
        {
            List<Vehicule> carList = vehicules.Where(x => x.Type == "car").ToList();
            double CarHp = 0;
            if (carList.Count > 0)
            {
                foreach (Vehicule vehicule in carList)
                {
                    CarHp += vehicule.Horsepower;
                }
                CarHp /= carList.Count; // Now is average CarHP
            }

            return CarHp;
        }
        private static double GetAverageTruckHP(List<Vehicule> vehicules)
        {
            List<Vehicule> truckList = vehicules.Where(x => x.Type == "truck").ToList();
            double truckHp = 0;
            if (truckList.Count > 0)
            {
                foreach (Vehicule vehicule in truckList)
                {
                    truckHp += vehicule.Horsepower;
                }
                truckHp /= truckList.Count; // Now is average CarHP
            }

            return truckHp;
        }
    }
}