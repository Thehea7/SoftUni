using System;

namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int totalSurface = int.Parse(Console.ReadLine());
            double grapePerM2 = double.Parse(Console.ReadLine());
            int requiredWine = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            //calculations
            double wine = 0.4 * totalSurface * grapePerM2 / 2.5;
            //conditions

            if (wine >= requiredWine)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - requiredWine)} liters left -> {Math.Ceiling((wine - requiredWine) / workers)} liters per person.");
            }

            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(requiredWine - wine)} liters wine needed.");
                
            }

        }
    }
}
