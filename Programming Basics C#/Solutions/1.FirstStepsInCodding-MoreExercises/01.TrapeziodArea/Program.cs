using System;

namespace _01.TrapeziodArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input

            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //Calculation (b1 + b2) * h / 2.
            double s = (b1 + b2) * h / 2.0;
            Console.WriteLine($"{s:F2}");
        }
    }
}
