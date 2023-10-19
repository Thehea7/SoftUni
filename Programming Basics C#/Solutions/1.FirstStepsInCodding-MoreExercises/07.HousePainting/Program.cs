using System;

namespace _07.HousePainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            //Calculations
            double totalGreen = Math.Pow(x, 2) * 2 + x * y * 2;
            double red = 2 * x * y + x * h;
            double green = totalGreen - 6.9;
            double paintGreen = green / 3.4;
            double paintRed = red / 4.3;
            //Print
            Console.WriteLine($"{paintGreen:f2}");
            Console.WriteLine($"{paintRed:f2}");


        }
    }
}
