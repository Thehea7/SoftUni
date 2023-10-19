using System;

namespace _02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int daysOff = int.Parse(Console.ReadLine());

            //Calc
            int workDays = 365 - daysOff;
            double playTime = workDays * 63 + daysOff * 127;
            double h = 30000;
         
            if (playTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Floor((playTime - h) / 60)} hours and {(playTime - h) % 60} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{Math.Floor((h - playTime) / 60)} hours and {(h - playTime) % 60} minutes less for play");
            }
        }
    }
}
