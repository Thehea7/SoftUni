namespace _03.Calculations
{
    internal class Program
    {
        static void Main()
        {
            string action = Console.ReadLine();
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            if (action == "add")
            {
                Add(firstNumber, secondNumber);
            }
            else if (action == "multiply")
            {
                Multiply(firstNumber, secondNumber);
            }
            else if (action == "subtract")
            {
                Subtract(firstNumber, secondNumber);
            }
            else if (action == "divide")
            {
                Divide(firstNumber, secondNumber);
            }
        }

        private static void Divide(double a, double b)
        {
            Console.WriteLine(1.0 * a / b);
        }

        private static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a - b}");
        }

        private static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a * b}");
        }

        private static void Add(double a, double b)
        {
            double result = a + b;
            Console.WriteLine(result);
        }
    }
}