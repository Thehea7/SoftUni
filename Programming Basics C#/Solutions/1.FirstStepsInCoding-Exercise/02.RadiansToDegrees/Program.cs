using System;

namespace _02.RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double radian = double.Parse(Console.ReadLine());

            //print
            Console.WriteLine(radian * 180 / Math.PI);
        }
    }
}
