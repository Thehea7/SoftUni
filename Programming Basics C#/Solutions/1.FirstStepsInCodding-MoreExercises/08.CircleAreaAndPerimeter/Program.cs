using System;

namespace _08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double r = double.Parse(Console.ReadLine());
            //Calc
            double P = 2 * r * Math.PI;
            double S = Math.PI * Math.Pow(r, 2);
            //Print
            Console.WriteLine($"{S:f2}");
            Console.WriteLine($"{P:f2}");
        }
    }
}
