namespace _03.SpeedRacing
{

    class Car
    {
        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            Fuel = fuel;
            ConsumptionPer1Km = consumption;
        }

        public string Model { get; set; }
        public double Fuel { get; set; }
        public double ConsumptionPer1Km { get; set; }
        public int DistanceTraveled { get; set; } = 0;

        public void Drive(Car car, int distance)
        {
            if (distance * ConsumptionPer1Km <= Fuel)
            {
                Fuel -= (distance * ConsumptionPer1Km);
                DistanceTraveled += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        public override string ToString()
        {
            return $"{Model} {Fuel:f2} {DistanceTraveled}";
        }
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
                double fuel = double.Parse(input[1]);
                double consumation = double.Parse(input[2]);

                Car car = new Car(model, fuel, consumation);
                cars.Add(car);
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                string model = arguments[1];
                int distance = int.Parse(arguments[2]);

                Car car = cars.Find(x => x.Model == model);
                car.Drive(car, distance);

            }

            cars.ForEach(x => Console.WriteLine(x));

        }

        
    }
}