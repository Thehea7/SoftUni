using System;

namespace _06.ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string name = Console.ReadLine();
            string fname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();

            Console.WriteLine($"You are {name} {fname}, a {age}-years old person from {town}.");
        }
    }
}
