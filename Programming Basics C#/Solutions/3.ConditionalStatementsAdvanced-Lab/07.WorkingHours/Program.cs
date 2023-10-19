using System;

namespace _07.WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int time = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            ////if

            //if (day == "Sunday")
            //{
            //    Console.WriteLine("closed");
            //}
            //else
            //{
            //    if (time >= 10 &&  time <= 18)
            //    {
            //        Console.WriteLine("open");
            //    }
            //    else
            //    { Console.WriteLine("closed"); }
            //}
            // above is 100/100, checking another solve
            if (day !="Sunday" && time >= 10 && time <= 18)
            {
                Console.WriteLine("open");
            }
            else { Console.WriteLine("closed"); }
        }
    }
}
