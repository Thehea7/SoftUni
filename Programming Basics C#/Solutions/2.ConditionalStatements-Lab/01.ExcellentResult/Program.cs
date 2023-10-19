using System;

namespace _01.ExcellentResult
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            double grade = double.Parse(Console.ReadLine());
            //condition
            if (grade >= 5.50)
                //Print
                Console.WriteLine("Excellent!");
        }
    }
}
