using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input

            double currentRecord = double.Parse(Console.ReadLine());
            double smeters = double.Parse(Console.ReadLine());
            double vspeed = double.Parse(Console.ReadLine());
            //calc
            double extratime = Math.Floor(smeters / 15) * 12.5;
            double time = smeters * vspeed;
            double totaltime = time + extratime;
            //condition
            if (totaltime < currentRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totaltime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totaltime - currentRecord:f2} seconds slower.");
            }
        }
    }
}
