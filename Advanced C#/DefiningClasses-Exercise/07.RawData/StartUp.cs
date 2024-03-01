using System.Threading.Channels;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();
            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(input[4], int.Parse(input[3]));
                List<Tire> tires = new List<Tire>();
                for (int j = 5; j < input.Length; j+=2)
                {
                    Tire tire = new Tire(int.Parse(input[j+1]), double.Parse(input[j]));
                    tires.Add(tire);
                }
                cars.Add(new Car(model, engine, cargo, tires));
                
            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars
                             .Where(x => x.Tires.Exists(tire => tire.Pressure < 1))
                             .Where(x => x.Cargo.Type == command))
                {
                    Console.WriteLine(car.Model);
                }
            }

            if (command == "flammable")
            {
                foreach (var car in cars
                             .Where(car => car.Engine.Power > 250)
                             .Where(car => car.Cargo.Type == command))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}