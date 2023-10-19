using System;
using System.ComponentModel.Design;

namespace _07.FuelTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string fuel = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            //conditions
            if (fuel == "Diesel")
            {
                if (volume < 25)
                {
                    Console.WriteLine($"Fill your tank with diesel!");
                }
                else
                {
                    Console.WriteLine($"You have enough diesel.");
                }
            }
            else if (fuel == "Gas")
            {
                if (volume < 25)
                {
                    Console.WriteLine($"Fill your tank with gas!");
                }
                else
                {
                    Console.WriteLine($"You have enough gas.");
                }
            }
            else if (fuel == "Gasoline")
            {
                if (volume < 25)
                {
                    Console.WriteLine($"Fill your tank with gasoline!");
                }
                else
                {
                    Console.WriteLine($"You have enough gasoline.");
                }
            }
            
            else 
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
