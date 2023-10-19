using System;

namespace _09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            double leignt = double.Parse(Console.ReadLine()) * 0.1;
            double high = double.Parse(Console.ReadLine()) * 0.1;
            double wide = double.Parse(Console.ReadLine()) * 0.1;
            double taken = double.Parse(Console.ReadLine()) * 0.01;
            //Calc
            double totalVolume = leignt * high * wide;
            double volume = totalVolume * (1 - taken);
            //Print
            Console.WriteLine(volume);
        }
    }
}
