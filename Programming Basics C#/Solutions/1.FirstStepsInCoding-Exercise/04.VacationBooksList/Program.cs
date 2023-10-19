using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            Console.WriteLine("Pages Left:");
            int volume = int.Parse(Console.ReadLine());
            Console.WriteLine("Pages per Hour:");
            int rate = int.Parse(Console.ReadLine());
            Console.WriteLine("Days left");
            int days = int.Parse(Console.ReadLine());
            //calc
            double hours = volume / days / rate;
            //Print
            Console.WriteLine($"The naughty boy must read {hours} hours every single day and never touch the phone.");
            //Console.WriteLine(hours);
        }
    }
}
