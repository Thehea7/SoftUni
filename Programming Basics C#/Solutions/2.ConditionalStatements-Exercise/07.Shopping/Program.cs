using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budjet = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            //calc
            double price = gpu * 250 + cpu * gpu * 250 * 0.35 + ram * gpu * 25;
            //condition
            if(gpu > cpu)
            {
                price = price * 0.85;
            }
            if(budjet >= price)
            {
                Console.WriteLine($"You have {budjet - price:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budjet:f2} leva more!");
            }
        }
    }
}
