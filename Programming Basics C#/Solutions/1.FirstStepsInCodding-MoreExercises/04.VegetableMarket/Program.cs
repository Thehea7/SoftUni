using System;

namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double PriceV = double.Parse(Console.ReadLine());
            double PriceF = double.Parse(Console.ReadLine());
            int vege = int.Parse(Console.ReadLine());
            int fruit = int.Parse(Console.ReadLine());
            //Calc
            double income = (vege * PriceV + fruit * PriceF) / 1.94;
            //Print
            Console.WriteLine($"{income:f2}");
        }
    }
}
