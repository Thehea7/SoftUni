namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            char operatorr = char.Parse(Console.ReadLine());
            double number2  = double.Parse(Console.ReadLine());

            double output = CheckOperatorAndReturnResult(operatorr, number1, number2);
            Console.WriteLine(output);
        }

        private static double CheckOperatorAndReturnResult(char operatorr, double number1, double number2)
        {
            double result = default;
            if (operatorr == '/')
            {
                result = 1.0 * number1 / number2;
            }
            else if (operatorr == '*')
            {
                result = number1 * number2;
            }
            else if (operatorr == '+')
            {
                result = number1 + number2;
            }
            else if (operatorr == '-')
            {
                result = number1 - number2;
            }

            return result;
        }
    }
}