using System.Threading.Channels;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            Dictionary<string,Car> cars = new();

            for (int i = 0; i < entries; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Car car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
                cars.Add(car.Model, car);
            }

            string command;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] arguments = command.Split();
                string model = arguments[1];
                double kilometars = double.Parse(arguments[2]);

                cars[model].Drive(kilometars);
            }

            foreach (var (model, car) in cars)
            {
                Console.WriteLine(car);
            }

        }
    }
}