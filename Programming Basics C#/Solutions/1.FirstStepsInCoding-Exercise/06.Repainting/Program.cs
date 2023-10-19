using System;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int water = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            //calc
            double orderPrice = (nylon + 2) * 1.5 + 1.1 * paint * 14.5 + water * 5 + 0.4;
            double pricePerHour = orderPrice * 0.3;
            double finalPrice = orderPrice + hours * pricePerHour;
            Console.WriteLine(finalPrice);
                
        }
    }
}
