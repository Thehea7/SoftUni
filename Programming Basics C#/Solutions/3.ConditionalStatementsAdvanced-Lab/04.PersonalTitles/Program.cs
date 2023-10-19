using System;

namespace _04.PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Input
            double age = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            //conditions

            if (age >= 16 && gender == "m")
            {
                Console.WriteLine("Mr.");
            }
            else if (age >= 16 && gender == "f")
            {
                Console.WriteLine("Ms.");

            }
            else if (age <= 16 && gender == "m")
            {
                Console.WriteLine("Master");
            }
            else if (age <= 16 && gender == "f")
            {
                Console.WriteLine("Miss");
            }
        }
    }
}
