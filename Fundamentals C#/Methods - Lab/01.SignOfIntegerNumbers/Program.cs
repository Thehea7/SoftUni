namespace _01.SignOfIntegerNumbers
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            SignOfIntegerNumbers(input);
        }

        private static void SignOfIntegerNumbers(int input)
        {
            if (input == 0)
            {
                Console.WriteLine($"The number {input} is zero.");
            }
            else if (input < 0)
            {
                Console.WriteLine($"The number {input} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {input} is positive.");
            }
        }
    }
}