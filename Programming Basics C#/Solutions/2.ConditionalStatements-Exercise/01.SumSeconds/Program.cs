using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            //calc
            int minutes = (time1 + time2 + time3) / 60;
            int seconds = (time1 + time2 + time3) % 60;
            //condition
            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }
        }
    }
}
