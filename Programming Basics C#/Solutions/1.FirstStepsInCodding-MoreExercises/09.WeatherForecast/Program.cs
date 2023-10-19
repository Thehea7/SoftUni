using System;

namespace _09.WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string forecast = Console.ReadLine();
            //
            if (forecast == "sunny")
            {
                Console.WriteLine("It's warm outside!");

            }
            else 
            {
                Console.WriteLine("It's cold outside!");
            }
        }
    }
}
