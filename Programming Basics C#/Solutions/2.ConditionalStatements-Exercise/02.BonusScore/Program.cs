using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input

            double n = int.Parse(Console.ReadLine());
            //bonus1
            double bonus = 0;
            if(n <= 100)
            {
                
                bonus = 5;
            }
            else if(n <=1000)
            {
                
                bonus = 0.2 * n;
            }
            else
            {
                
                bonus = 0.1 * n;
            }
            //bonus2
            if (n % 2 == 0)
            {
                
                bonus = bonus + 1;
            }
            if(n % 10 == 5)
            {
                
                bonus = bonus + 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(n + bonus);
        }
    }
}
