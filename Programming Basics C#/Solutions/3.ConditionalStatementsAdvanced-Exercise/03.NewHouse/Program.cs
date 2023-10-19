using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string flower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            //
            double price = 0;
            double discount = 1;

            if (flower == "Roses")
            {
                price = 5;
                if (count > 80) { discount = 0.9; }
            }
            else if (flower == "Dahlias")
            {
                price = 3.8;
                if (count > 90) { discount = 0.85; }
            }
            else if (flower == "Tulips")
            {
                price = 2.8;
                    if (count > 80) { discount = 0.85; }
            }
            else if(flower == "Narcissus")
            {
                price = 3;
                if (count < 120) { discount = 1.15; }
            }
            else
            {
                price = 2.5;
                    if (count < 80) { discount = 1.2; }
            }
            double expences = count * price * discount;
            if (expences <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flower} and {budget - expences:f2} leva left.");

            }
            else
            {
                Console.WriteLine($"Not enough money, you need {expences - budget:f2} leva more.");
            }
        }
    }
}
