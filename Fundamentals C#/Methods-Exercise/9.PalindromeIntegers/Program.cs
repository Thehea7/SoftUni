using System;

namespace _9.PalindromeIntegers
{
    internal class Program
    {
        static void Main()
        {
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(IsPalindrom(input));
            }
        }

        static bool IsPalindrom(string input)
        {
            string first = input.Substring(0, input.Length / 2);
            char[] arr = input.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }
}