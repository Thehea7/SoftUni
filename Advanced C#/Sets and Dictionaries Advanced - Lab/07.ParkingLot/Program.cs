namespace _07.ParkingLot
{
    internal class Program
    {
        static void Main()
        {
            HashSet<string> cars = new HashSet<string>();

            string commands;
            while ((commands = Console.ReadLine()) != "END")
            {
                string[] arguments = commands.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string car = arguments[1];

                if (command == "IN")
                {
                    cars.Add(car);
                }
                else
                {
                    cars.Remove(car);
                }
            }

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}