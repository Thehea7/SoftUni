using System;

namespace _05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double budjet = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double pricePerStatist = double.Parse(Console.ReadLine());
            //calc
            double clothing = statist * pricePerStatist;
            double decor = 0.1 * budjet;
            if(statist > 150)
            {
                clothing = 0.9 * clothing;
            }
            double expenses = clothing + decor;
            if(expenses <= budjet)
            {
                Console.WriteLine($"Action!");
                Console.WriteLine($"Wingard starts filming with {budjet - expenses:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {expenses - budjet:f2} leva more.");
            }
        }
    }
}
