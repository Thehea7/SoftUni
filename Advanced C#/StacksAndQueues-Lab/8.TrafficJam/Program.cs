namespace _8.TrafficJam
{
    internal class Program
    {
        static void Main()
        {
            int capacity = int.Parse(Console.ReadLine());
            string command;
            int passedCars = 0;
            Queue<string> cars = new Queue<string>();
            while ((command = Console.ReadLine()) != "end")
            {
                if (command != "green")
                {
                    cars.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < capacity; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCars++;
                        }
                    }
                }

            }
            Console.WriteLine($"{passedCars} cars passed the crossroads.");
        }
    }
}