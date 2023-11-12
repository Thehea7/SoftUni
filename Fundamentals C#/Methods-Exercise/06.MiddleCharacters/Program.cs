namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            bool isEven = CheckIfEven(input);
            if (!isEven)
            {
                PrintOdd(input);
            }
            else
            {
                PrintEven(input);
            }
        }

        static bool CheckIfEven(string input)
        {
            bool isEven = false;
            if (input.Length % 2 == 0)
            {
                isEven = true;
            }

            return isEven;
        }

        static void PrintOdd(string input)
        {
            int index = (input.Length - 1) / 2;
            Console.WriteLine(input[index]);
        }

        static void PrintEven(string input)
        {
            int index2 = (input.Length / 2);
            int index1 = index2 - 1;
            Console.WriteLine($"{input[index1]}{input[index2]}");
        }
    }
}