using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string projection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            //calc
            int seats  = columns * rows;
            double price = 0;
            //
            switch (projection)
            {
                case "Premiere": price = 12; break;
                case "Normal": price = 7.5; break;
                case "Discount": price = 5; break;
            }
            double income = seats * price;
            Console.WriteLine($"{income:f2}");

        }
    }
}
