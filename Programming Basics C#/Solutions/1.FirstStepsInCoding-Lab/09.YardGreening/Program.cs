using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double m2 = double.Parse(Console.ReadLine());
            //calculations
            double price = m2 * 7.61;
            double discount = 0.18 * price;
            double fprice = price - discount;

            //Print
            Console.WriteLine($"The final price is: {fprice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
