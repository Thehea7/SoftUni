namespace _01.RapidCourier
{
    internal class Program
    {
        static void Main()
        {
            Stack<int> packages = new (Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Queue<int> couriers = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            int totalWeigh = 0;

            while (packages.Count > 0 && couriers.Count > 0)
            {
                int courier = couriers.Dequeue();
                int package = packages.Pop();
                if (courier >= package)
                {
                    totalWeigh += package;
                    int newCourier = courier - 2 * package;
                    if (newCourier > 0)
                    {
                        couriers.Enqueue(newCourier);
                    }
                }
                else
                {
                    int newPackage = package - courier;
                    totalWeigh += courier;
                    packages.Push(newPackage);
                }
            }

            Console.WriteLine($"Total weight: {totalWeigh} kg");
            if (packages.Count == 0 && couriers.Count == 0)
            {
                Console.WriteLine("Congratulations, all packages were delivered successfully by the couriers today.");
            }
            else if (packages.Count == 0)
            {
                Console.WriteLine( $"Couriers are still on duty: {string.Join(", ", couriers)} but there are no more packages to deliver.");
            }
            else
            {
                Console.WriteLine($"Unfortunately, there are no more available couriers to deliver the following packages: {string.Join(", ", packages)}");
            }
        }
    }
}
