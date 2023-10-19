using System;

namespace _07.FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegi = int.Parse(Console.ReadLine());
            //Calc
            double orderPrice = chicken * 10.35 + fish * 12.4 + vegi * 8.15;
            double dessertPrice = 0.2 * orderPrice;
            double finalPrice = orderPrice + dessertPrice + 2.5;
            //print
            Console.WriteLine(finalPrice);
        }
    }
}
