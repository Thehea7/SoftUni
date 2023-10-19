using System;

namespace _05.SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int pen = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int cleaning = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine()) * 0.01;
            //calc
            double order = pen * 5.8 + marker * 7.2 + cleaning * 1.2;
            double finalPrice = order - order * discount;
            //Print
            Console.WriteLine(finalPrice);
        }
    }
}
