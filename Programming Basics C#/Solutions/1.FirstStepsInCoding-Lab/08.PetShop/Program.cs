using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int nDogFood = int.Parse(Console.ReadLine());
            int nCatFood = int.Parse(Console.ReadLine());
            //calculations
            double total = nCatFood * 4 + nDogFood * 2.5;
            //prin
            Console.WriteLine(total + " lv.");
        }
    }
}
