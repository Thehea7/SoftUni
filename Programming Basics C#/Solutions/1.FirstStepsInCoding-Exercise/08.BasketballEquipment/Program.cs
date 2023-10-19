using System;

namespace _08.BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int tax = int.Parse(Console.ReadLine());
            //Calc
            double shoose = 0.6 * tax;
            double equip = 0.8 * shoose;
            double ball = 0.25 * equip;
            double razni = 0.2 * ball;
            double total = tax + shoose + equip + ball + razni;
            //Print
            Console.WriteLine(total);
        }
    }
}
