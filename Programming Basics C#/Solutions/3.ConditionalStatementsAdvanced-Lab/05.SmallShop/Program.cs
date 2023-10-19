using System;

namespace _05.SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;


            //Calculations

            if (product == "coffee")
            {
                if (town == "Sofia") { price = 0.5; }
                if (town == "Plovdiv") { price = 0.40; }
                if (town == "Varna") { price = 0.45; }

            }
            else if (product == "water")
            {
                if (town == "Sofia") { price = 0.8; }
                if(town == "Plovdiv" ||  town == "Varna") { price = 0.7; }
            }
            else if (product == "beer")
            {
                if(town == "Sofia") { price = 1.20; }
                if (town == "Plovdiv") { price = 1.15; }
                if (town == "Varna") { price = 1.10; }
            }
            else if (product == "sweets")
            {
                if (town == "Sofia") { price = 1.45; }
                if (town == "Plovdiv") { price = 1.30; }
                if (town == "Varna") { price = 1.35; }
            }
            else if (product == "peanuts")
            {
                if (town == "Sofia") { price = 1.6; }
                if (town == "Plovdiv") { price = 1.50; }
                if (town == "Varna") { price = 1.55; }
            }

            //print
            Console.WriteLine($"{price * quantity}");

        }
    }
}
