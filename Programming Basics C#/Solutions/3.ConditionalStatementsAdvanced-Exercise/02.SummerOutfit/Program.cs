using System;

namespace _02.SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int degrees = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();
            //
            string outfit = "";
            string shoose = "";
            if (dayTime == "Evening" || (dayTime == "Afternoon" && degrees >= 10 && degrees <= 18) || (dayTime == "Morning" && degrees > 18 && degrees <= 24))
            {
                outfit = "Shirt";
                shoose = "Moccasins";
            }
            else if (dayTime == "Afternoon")
            {
                if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoose = "Sandals";
                }
                else
                {
                    outfit = "Swim Suit";
                    shoose = "Barefoot";
                }
            }
            else if (dayTime == "Morning" && degrees >= 25)
            {
                outfit = "T-Shirt";
                shoose = "Sandals";
            }

            else { outfit = "Sweatshirt"; shoose = "Sneakers"; }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoose}.");
        }
    }
}
