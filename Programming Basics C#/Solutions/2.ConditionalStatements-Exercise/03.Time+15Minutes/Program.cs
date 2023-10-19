using System;

namespace _03.Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            int hour = int.Parse(Console.ReadLine());
            int sminute = int.Parse(Console.ReadLine());
            //...
            int minutes = sminute + 15;
            if(minutes > 59)
            {
                hour = hour + 1;
                minutes = minutes - 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }

        }
    }
}
