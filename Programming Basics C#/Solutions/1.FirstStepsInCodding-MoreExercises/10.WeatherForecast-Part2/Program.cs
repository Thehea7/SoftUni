using System;

namespace _10.WeatherForecast_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gradusi = double.Parse(Console.ReadLine());

            if (gradusi > 35)
            { 
                Console.WriteLine("unknown");
            }
            else if (gradusi >= 26)
            {
                Console.WriteLine("Hot");
            }
            else if(gradusi >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (gradusi >= 15)
            {
                Console.WriteLine("Mild");
            }
            else if (gradusi >= 12)
            {
                Console.WriteLine("Cool");
            }
            else if (gradusi >= 5)
            {
                Console.WriteLine("Cold");

            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
