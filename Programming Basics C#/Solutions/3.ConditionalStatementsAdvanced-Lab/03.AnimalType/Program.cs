using System;

namespace _03.AnimalType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Inpt
            string animal = Console.ReadLine();
            //conditions

            if (animal == "dog") { Console.WriteLine("mammal"); }
            else if (animal == "crocodile" || animal == "snake" || animal == "tortoise") { Console.WriteLine("reptile"); }
            else { Console.WriteLine("unknown"); }
        }
    }
}
