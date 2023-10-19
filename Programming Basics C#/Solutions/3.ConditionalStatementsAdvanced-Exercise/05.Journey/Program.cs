using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            //
            string destination = "";
            double expences = 0;
            string staying = "";
            
            //if
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer") { expences = budget * 0.3; }
                else { expences = budget * 0.7; }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if(season == "summer") { expences = budget * 0.4; }
                else { expences = budget * 0.8; }
            }
            else 
            { 
                expences = budget * 0.9;
                destination = "Europe";
            }

            Console.WriteLine($"Somewhere in {destination}");
            if (season == "winter" || destination == "Europe") { staying = "Hotel"; }
            else { staying = "Camp"; }
            Console.WriteLine($"{staying} - {expences:f2}");
        }
    }
}
