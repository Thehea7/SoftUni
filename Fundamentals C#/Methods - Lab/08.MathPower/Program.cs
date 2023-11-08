namespace _08.MathPower
{
    internal class Program
    {
        static void Main()
        {
            var input = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());

            Console.WriteLine(Power(input, power));
        }

        private static double Power(double input, double power)
        {
            double output = Math.Pow(input, power);
            return output;
        }
    }
}