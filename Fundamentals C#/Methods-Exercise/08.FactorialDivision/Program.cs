namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main()
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());

            double factorial1 = Factorial(number1);
            double factorial2 = Factorial(number2);

            double output = factorial1 / factorial2;
            Console.WriteLine($"{output:f2}");
            
        }

        static double Factorial(double number)
        {
            double fact = 1;
            for (int i = 1; i <= number; i++)
            {
                fact = fact * i;
            }

            return fact;
        }
    }
}