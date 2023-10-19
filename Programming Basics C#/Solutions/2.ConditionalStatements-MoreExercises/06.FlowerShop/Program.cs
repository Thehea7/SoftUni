using System;
using System.Runtime.Intrinsics.X86;

namespace _06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int kaktusi = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());
            //Calculations
            double profit = (magnolii * 3.25 + zumbuli * 4 + rozi * 3.5 + kaktusi * 8) * 0.95;
            //condition
            if (profit >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(profit - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - profit)} leva.");
            }
        }
    }
}
