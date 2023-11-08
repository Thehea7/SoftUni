namespace _10.MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main()
        {
            var input = Input();
            int oddSum = OddSum(input);
            int evenSum = EvenSum(input);

            Console.WriteLine(oddSum * evenSum);
        }

        private static int[] Input()
        {
            string number = Math.Abs(int.Parse(Console.ReadLine())).ToString();
            int[] input = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                input[i] = int.Parse(number[i].ToString());
            }

            return input;
        }

        static int OddSum(int[] input)
        {
            int oddSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 != 0)
                {
                    oddSum += Math.Abs(input[i]);
                }
            }
            return oddSum;
        }
        static int EvenSum(int[] input)
        {
            int evenSum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    evenSum += Math.Abs(input[i]);
                }
            }
            return evenSum;
        }
    }
}