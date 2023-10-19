using System;

namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string sign = Console.ReadLine();
            double n3 = n2;
            //
            if (sign == "+")
            {
                if ((n1 + n2) % 2 == 0) { Console.WriteLine($"{n1} + {n2} = {n1 + n2} - even"); }
                else { Console.WriteLine($"{n1} + {n2} = {n1 + n2} - odd"); }
            }
            else if (sign == "-")
            {
                if ((n1 - n2) % 2 == 0) { Console.WriteLine($"{n1} - {n2} = {n1 - n2} - even"); }
                else { Console.WriteLine($"{n1} - {n2} = {n1 - n2} - odd"); }
            }
            else if (sign == "*")
            {
                if ((n1 * n2) % 2 == 0) { Console.WriteLine($"{n1} * {n2} = {n1 * n2} - even"); }
                else { Console.WriteLine($"{n1} * {n2} = {n1 * n2} - odd"); }
            }
            else if (sign == "/")
             
            {
                if (n2 != 0)
                {
                    Console.WriteLine($"{n1} / {n2} = {n1 / n3:f2}");
                }
                else { Console.WriteLine($"Cannot divide {n1} by zero"); }
                
            }
            else if (sign == "%")
            {
                if (n2 != 0)
                {
                    Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                }
                else { Console.WriteLine($"Cannot divide {n1} by zero"); }
            }
        }
    }
}
