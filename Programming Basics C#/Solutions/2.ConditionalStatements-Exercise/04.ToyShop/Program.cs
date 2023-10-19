using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            double priceTrip = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());
            //calc
            int toys = puzzle + doll + bear + minion + truck;
            double revenue = puzzle * 2.6 + doll * 3 + bear * 4.10 + minion * 8.2 + truck * 2;
            if (toys >= 50)
            {
                revenue = 0.75 * revenue;
            }
            double profit = revenue * 0.9;
            if (profit >= priceTrip)
            {
                Console.WriteLine($"Yes! {profit - priceTrip:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceTrip - profit:f2} lv needed.");
            }
        }
    }
}
