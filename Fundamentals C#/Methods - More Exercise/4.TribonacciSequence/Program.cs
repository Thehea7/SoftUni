namespace _4.TribonacciSequence
{
    internal class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());

            PrintFibunachiSequence(input);
        }

        private static void PrintFibunachiSequence(int input)
        {
            int[] tribunachiPrime = { 0, 0, 1 };

            for (int i = 1; i < input; i++)
            {
                int[] tribunachi = new int[3];
                tribunachi[0] = tribunachiPrime[1];
                tribunachi[1] = tribunachiPrime[2];
                tribunachi[2] = tribunachiPrime[0] + tribunachiPrime[1] + tribunachiPrime[2];

                tribunachiPrime[0] = tribunachi[0];
                tribunachiPrime[1] = tribunachi[1];
                tribunachiPrime[2] = tribunachi[2];

                Console.Write($"{tribunachiPrime[2]} ");
            }
        }
    }
}