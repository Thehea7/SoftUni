using System;

namespace _06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input

            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());
            //Calculations
            double palamudPrice = 1.6 * skumriqPrice;
            double safridPrice = 1.8 * cacaPrice;
            double totalPrice = 7.5 * kgMidi + kgPalamud * palamudPrice + kgSafrid * safridPrice;
            //Print
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
