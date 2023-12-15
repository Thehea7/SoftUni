namespace _04.RawData
{
    class Engine
    {
        public Engine(int speed, int power)
        {
            EngineSpeed = speed;
            EnginePower = power;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    class Cargo
    {
        public Cargo(int weight, string type)
        {
            Weight = weight;
            Type = type;
        }
        public int Weight { get; set; }
        public string Type { get; set; }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }

    }
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                int weight = int.Parse(input[3]);
                string type = input[4];
                Car car = new Car(model, speed, power, weight, type);
                cars.Add(car);
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                Fragile(cars, command);
            }
            else if (command == "flamable")
            {
                Flamable(cars, command);
            }
        }

        private static void Fragile(List<Car> cars, string command)
        {
            List<Car> orderedList = cars.Where(x => x.Cargo.Type == command).ToList();
            orderedList = orderedList.Where(x => x.Cargo.Weight < 1000).ToList();
            orderedList.ForEach(x => Console.WriteLine(x.Model));
        }
        private static void Flamable(List<Car> cars, string command)
        {
            List<Car> orderedList = cars.Where(x => x.Cargo.Type == command).ToList();
            orderedList = orderedList.Where(x => x.Engine.EnginePower > 250).ToList();
            orderedList.ForEach(x => Console.WriteLine(x.Model));
        }
    }
}