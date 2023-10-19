using System;
using System.ComponentModel.Design;

namespace _04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int distance = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();
            //print
            if (distance < 20)
            {
                if (day == "day")
                {
                    Console.WriteLine($"{(0.7 + (distance * 0.79)):f2}");

                }
                else if (day == "night")
                {
                    Console.WriteLine($"{(0.7 + (distance * 0.9)):f2}");
                }
            }
            else if(distance < 100)
            {
                Console.WriteLine($"{distance * 0.09:f2}");

            }
            else
            {
                Console.WriteLine($"{distance * 0.06:f2}");
            }
            

        }
    }
}
