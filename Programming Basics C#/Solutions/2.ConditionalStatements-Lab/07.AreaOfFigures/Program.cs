using System;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string figure = Console.ReadLine();
            //Conditions

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine($"{a * a:f3}");
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse((Console.ReadLine()));
                double b = double.Parse((Console.ReadLine()));
                Console.WriteLine($"{a * b:f3}");
            }
            else if (figure == "circle")
            {
                double r = double.Parse((Console.ReadLine()));
                Console.WriteLine($"{Math.PI * r * r:f3}");
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse((Console.ReadLine()));
                Console.WriteLine($"{0.5 * a * ha:f3}");
            }
        }

    }
}
