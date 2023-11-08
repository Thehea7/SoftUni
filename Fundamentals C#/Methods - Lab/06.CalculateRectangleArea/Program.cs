namespace _06.CalculateRectangleArea
{
    internal class Program
    {
        static void Main()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            
            Console.WriteLine(CalculateReturnArea(width, height));
        }

        private static double CalculateReturnArea(double width, double height)
        {
            double area = width * height;
            return area;
        }
    }
}