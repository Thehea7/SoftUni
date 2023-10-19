using System;

namespace _02.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            //calc
            double s = a * ha * 0.5;
            Console.WriteLine($"{s:f2}");
        }
    }
}
