using System;

namespace _06.NumberInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double number = double.Parse(Console.ReadLine());
            //if
            if (number != 0 && number >= -100 && number <=100 )
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }
        }
    }
}
