namespace _07.TruckTour
{
    class Pump
    {
        public int Number { get; set; }
        public int Fuel { get; set; }
        public int Distance { get; set; }

        public Pump(int number, int fuel, int distance)
        {
            Number = number; Fuel = fuel; Distance = distance;
        }
    }
    internal class Program
    {
        static void Main()
        {
            int pumpsCount = int.Parse(Console.ReadLine());
            int count = 0;
            Queue<Pump> queue = new Queue<Pump>();
            for (int i = 0; i < pumpsCount; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int fuel = input[0];
                int distance = input[1];
                Pump pump = new Pump(i, fuel, distance);
                queue.Enqueue(pump);
            }

            int remains = 0;
            while (count != pumpsCount)
            {
                var currentPump = queue.Dequeue();
                if (currentPump.Fuel + remains >= currentPump.Distance)
                {
                    count++;
                    remains = currentPump.Fuel + remains - currentPump.Distance;
                    queue.Enqueue(currentPump);
                }
                else
                {
                    remains = 0;
                    count = 0;
                    queue.Enqueue(currentPump);
                }
            }
            Pump firstPump = queue.Dequeue();


            Console.WriteLine(firstPump.Number);
        }
    }
}