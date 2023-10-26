namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal[] input = Console.ReadLine()
                .Split(" ")
                .Select(decimal.Parse)
                .ToArray();


            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} => {(int)Math.Round(input[i], 0, MidpointRounding.AwayFromZero)}");

            }

        }
    }
}