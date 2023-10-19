using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int days = int.Parse(Console.ReadLine()) - 1;
            string stay = Console.ReadLine();
            string grade = Console.ReadLine();
            //
            double discount = 1;
            double price = 0;
            //

            if (stay == "room for one person")
            {
                price = 18;
                
            }
            else if (stay == "apartment")
            {
                price = 25;
                if (days < 9)
                {
                    discount = 0.7;
                }
                else if (days < 15)
                {
                    discount = 0.65;
                }
                else { discount = 0.5; }
            }
            else if(stay == "president apartment")
            {
                price = 35;
                if (days < 9)
                {
                    discount = 0.9;
                }
                else if (days < 15)
                {
                    discount = 0.85;
                }
                else { discount = 0.8; }
            }
            double totalPrice = days * price * discount;

            if (grade == "positive")
            {
                Console.WriteLine($"{totalPrice * 1.25:f2}");
            }
            else
            {
                Console.WriteLine($"{totalPrice * 0.9:f2}");
            }
        }
    }
}
