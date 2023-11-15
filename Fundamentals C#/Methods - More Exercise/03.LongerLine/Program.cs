namespace _03.LongerLine
{
    internal class Program
    {
        static void Main()
        {
            var x1 = ReadInput(out var y1, out var x2, out var y2, out var x3, out var y3, out var x4, out var y4);


            CheckLongerLine(x2, x1, y2, y1, x4, x3, y4, y3);
        }

        private static double ReadInput(out double y1, out double x2, out double y2, out double x3, out double y3,
            out double x4, out double y4)
        {
            double x1 = double.Parse(Console.ReadLine());
            y1 = double.Parse(Console.ReadLine());
            x2 = double.Parse(Console.ReadLine());
            y2 = double.Parse(Console.ReadLine());
            x3 = double.Parse(Console.ReadLine());
            y3 = double.Parse(Console.ReadLine());
            x4 = double.Parse(Console.ReadLine());
            y4 = double.Parse(Console.ReadLine());
            return x1;
        }

        private static void CheckLongerLine(double x2, double x1, double y2, double y1, double x4, double x3, double y4,
            double y3)
        {
            double distance1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double distance2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            if (distance1 > distance2)
            {
                PrintClosestPoint(x1, y1, x2, y2);
            }
            else
            {
                PrintClosestPoint(x3, y3, x4, y4);
            }
        }

        private static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double disposition1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double disposition2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (disposition1 > disposition2)
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
        }

    }
}