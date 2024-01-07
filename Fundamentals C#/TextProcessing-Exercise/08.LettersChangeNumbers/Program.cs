namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;

            foreach (var str in input)
            {
               totalSum += AddSum(totalSum, str);
            }

            Console.WriteLine($"{totalSum:f2}");
        }

        private static decimal AddSum(decimal totalSum, string str)
        {
            decimal number = decimal.Parse(str.Substring(1, (str.Length - 2)));
            if (char.IsUpper(str.First()))
            {
                number /= str[0] - 64;
            }
            else
            {
                number *= str[0] - 96;
            }

            if (char.IsUpper(str.Last()))
            {
                number -= str.Last() - 64;
            }
            else
            {
                number += str.Last() - 96;
            }
            //totalSum += number;
            return number;
        }
    }
}