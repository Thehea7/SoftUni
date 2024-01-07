namespace _02.CharacterMultiplier
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            int itterations = Math.Min(input[1].Length, input[0].Length);
            int Maxitterations = Math.Max(input[1].Length, input[0].Length);


            int totalSum = 0;

            for (int i = 0; i < Maxitterations; i++)
            {
                if (i < itterations)
                {
                    totalSum += input[0][i] * input[1][i];
                }
                else if (i < input[0].Length)
                {
                    totalSum += input[0][i];
                }
                else if(i < input[1].Length)
                {
                    totalSum += input[1][i];
                }
            }

            Console.WriteLine(totalSum);
        }
    }
}

