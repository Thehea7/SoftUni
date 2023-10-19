using System;

namespace _02.GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int a = int.Parse(Console.ReadLine()); 
            int b = int.Parse(Console.ReadLine());
            //Condition
            if (a > b)
            {
                Console.WriteLine(a);
            }
            else 
            {
                Console.WriteLine(b);
            }
        }
    }
}
