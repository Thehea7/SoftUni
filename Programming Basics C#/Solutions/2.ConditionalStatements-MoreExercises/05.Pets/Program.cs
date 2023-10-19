using System;

namespace _05.Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dog = double.Parse(Console.ReadLine());
            double cat = double.Parse(Console.ReadLine());
            double tourtle = double.Parse(Console.ReadLine()) / 1000;

            //calculations
            double requiredFood = (dog + cat + tourtle) * days;
            //condition
            if (requiredFood <= foodLeft)
            {
                Console.WriteLine($"{Math.Floor(foodLeft - requiredFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(requiredFood - foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
