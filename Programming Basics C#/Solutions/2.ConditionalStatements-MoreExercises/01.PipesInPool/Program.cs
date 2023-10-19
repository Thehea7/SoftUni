using System;
using System.Data.SqlTypes;

namespace _01.PipesInPool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            //calculations

            double filledWater = p1 * hours + p2 * hours;
            //Conditions
            if(filledWater <= volume)
            {
                Console.WriteLine($"The pool is {filledWater / volume * 100}% full. Pipe 1: {p1 * hours * 100 / filledWater}%. Pipe 2: {p2 * hours * 100 / filledWater}%.");
            }
            else
            {
                Console.WriteLine($"For {hours} hours the pool overflows with {filledWater - volume} liters."
);
            }

        }
    }
}
