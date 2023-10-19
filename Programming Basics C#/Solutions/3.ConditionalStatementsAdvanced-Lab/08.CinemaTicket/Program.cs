using System;

namespace _08.CinemaTicket
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Input
           string day = Console.ReadLine();
            //if

            switch(day)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine("12");
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine("14");
                    break;
                    default: Console.WriteLine("16");
                    break;

            }
        }
    }
}
