using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            //
            double priceApp = 0;
            double priceStudio = 0;
            double discountApp = 1;
            double discountStudio = 1;
            if (days > 14) { discountApp = 0.9; }

            if (month == "May" || month == "October")
            {
                priceApp = 65;
                priceStudio = 50;
                if (days > 14) { discountStudio = 0.7; }
                else if (days > 7) { discountStudio = 0.95; }
            }
            else if (month == "June" || month == "September")
            {
                priceApp = 68.70;
                priceStudio = 75.20;
                if (days > 14) { discountStudio = 0.8; }
            }
            else { priceApp = 77; priceStudio = 76; }

            //
            Console.WriteLine($"Apartment: {days * priceApp * discountApp:f2} lv.");
            Console.WriteLine($"Studio: {days * priceStudio * discountStudio:f2} lv.");

        }
    }
}
