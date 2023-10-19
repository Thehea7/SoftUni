using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string moovie = Console.ReadLine();
            int serieLeight = int.Parse(Console.ReadLine());
            int breakLeight = int.Parse(Console.ReadLine());
            //calc
            double freetime = breakLeight - (0.125 * breakLeight + 0.25 * breakLeight);
            //Condition
            if (freetime >= serieLeight)
            {
                Console.WriteLine($"You have enough time to watch {moovie} and left with {Math.Ceiling(freetime - serieLeight)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {moovie}, you need {Math.Ceiling(serieLeight - freetime)} more minutes.");
            }
        }
    }
}
