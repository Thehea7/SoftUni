using System;

namespace _03.CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double celsium = double.Parse(Console.ReadLine());
            //T (° F) = T (° C) × 1,8 + 32
            double F = celsium * 1.8 + 32;
            //Print
            Console.WriteLine($"{F:f2}");
        }
    }
}
