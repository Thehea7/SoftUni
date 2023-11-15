namespace _02.CenterPoint
{
    internal class Program
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());



            PrintClosestPoint(x1, y1, x2, y2);
        }

        private static void PrintClosestPoint(double x1, double y1, double x2, double y2)
        {
            double disposition1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double disposition2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));

            if (disposition1 > disposition2)
            {
                Console.WriteLine($"({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x1}, {y1})");
            }
        }
    }
}

