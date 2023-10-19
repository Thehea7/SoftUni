using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int men = int.Parse(Console.ReadLine());
            ///
            double price = 0;
            double discount = 1;
            switch(season)
            {
                case "Spring": price = 3000;
                    break;
                case "Summer":
                case "Autumn": price = 4200;
                    break;
                case "Winter": price = 2600;
                    break;
            }
            if (men <= 6) { discount = 0.9; }
            else if (men <= 11) { discount = 0.85; }
            else { discount = 0.75; }

            double expences = price * discount;
            if (men % 2  == 0 && season != "Autumn") { expences = price * discount * 0.95; }

            //Print
            if (budget >= expences) { Console.WriteLine($"Yes! You have {budget - expences:f2} leva left."); }
            else { Console.WriteLine($"Not enough money! You need {expences - budget:f2} leva."); }

        }
    }
}
