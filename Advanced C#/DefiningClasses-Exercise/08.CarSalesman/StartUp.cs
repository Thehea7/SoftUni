using System.Threading.Channels;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            Dictionary<string, Engine> engines = new();
            List<Car> cars = new List<Car>();

            GetEngines(engines);
            GetCars(engines, cars);

            cars.ForEach(Console.WriteLine);
        }

        private static void GetCars(Dictionary<string, Engine> engines, List<Car> cars)
        {
            int carsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < carsCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                string enginemodel = input[1];
                Car car = new Car(model, engines[enginemodel]);
                if (input.Length > 2)
                {
                    bool isNumber = int.TryParse(input[2], out int weight);
                    if (isNumber)
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = input[2];
                    }

                }

                if (input.Length > 3)
                {
                    bool isNumber = int.TryParse(input[3], out int weight);
                    if (isNumber)
                    {
                        car.Weight = weight;
                    }
                    else
                    {
                        car.Color = input[3];
                    }
                }
                cars.Add(car);
            }
        }

        private static void GetEngines(Dictionary<string, Engine> engines)
        {
            int enginesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < enginesCount; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                Engine engine = new Engine(model, int.Parse(input[1]));
                if (input.Length > 2)
                {
                    bool isNumber = int.TryParse(input[2], out int displacement);
                    if (isNumber)
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = input[2];
                    }
                }

                if (input.Length > 3)
                {
                    bool isNumber = int.TryParse(input[3], out int displacement);
                    if (isNumber)
                    {
                        engine.Displacement = displacement;
                    }
                    else
                    {
                        engine.Efficiency = input[3];
                    }
                }
                engines.Add(model, engine);
            }
        }
    }
}