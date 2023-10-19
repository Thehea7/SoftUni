using System;

namespace _05.Number100_200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int a = int.Parse(Console.ReadLine());
            //Condition
            if (a < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (a <=200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
