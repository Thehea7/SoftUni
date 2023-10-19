using System;

namespace _11.FruitShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;
            //calc
            if (day == "Monday" || day == "Tuesday" ||  day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana": price = 2.5; break;
                    case "apple": price = 1.2; break;
                    case "orange": price = 0.85; break;
                    case "grapefruit": price = 1.45; break;
                    case "kiwi": price = 2.7; break;
                    case "pineapple": price = 5.5; break;
                    case "grapes": price = 3.85; break;
                        default: Console.WriteLine("error"); ; break;

                }

            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana": price = 2.7; break;
                    case "apple": price = 1.25; break;
                    case "orange": price = 0.9; break;
                    case "grapefruit": price = 1.6; break;
                    case "kiwi": price = 3; break;
                    case "pineapple": price = 5.6; break;
                    case "grapes": price = 4.2; break;
                    default: Console.WriteLine("error"); ; break;

                }
            }
            else { Console.WriteLine("error"); }

            if (price != 0)
            Console.WriteLine($"{price * quantity:f2}");
        }
        
    }
}
