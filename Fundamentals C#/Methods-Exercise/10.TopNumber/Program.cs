namespace _10.TopNumber
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            PrintTopNumbersToInput(input);
        }

        private static void PrintTopNumbersToInput(int n)
        {
            for (int i = 17; i <= n; i++)
            {
                bool isDivisbleBy8 = IsDivisibleBy8(i);
                bool holdsOddDigit = HoldsOddDigit(i);

                if (isDivisbleBy8 && holdsOddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsDivisibleBy8(int n)
        {
            int sum = 0;
            bool isDivisible = false;
            while (n != 0)
            {
                int curentNumber = n % 10;
                sum += curentNumber;
                n /= 10;
            }

            if (sum % 8 == 0)
            {
                isDivisible = true;
            }

            return isDivisible;
        }

        static bool HoldsOddDigit(int n)
        {
            bool holdsOddDigit = false;
            while (n != 0)
            {
                int curentNumber = n % 10;
                if (curentNumber % 2 != 0)
                {
                    holdsOddDigit = true;
                    break;
                }
                n /= 10;
            }

            return holdsOddDigit;
        }
    }
}