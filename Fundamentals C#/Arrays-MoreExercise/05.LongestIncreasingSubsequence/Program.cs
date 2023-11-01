using System.Runtime.InteropServices;

namespace _05.LongestIncreasingSubsequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numberPotential = new int[input.Length];
            int[] prevBestIndex = new int[input.Length];

            for (int currentNumber = 0; currentNumber < input.Length; currentNumber++)
            {
                int prevBestPotentialIndex = -1;
                int currentBestPotential = 1;

                for (int n = 0; n <= currentNumber; n++)
                {
                    if (input[currentNumber] > input[n])
                    {
                        int currentPotential = 1 + numberPotential[n];
                        
                        if (currentPotential > currentBestPotential)
                        {
                            currentBestPotential = currentPotential;
                            prevBestPotentialIndex = n;
                        }
                    }
                }
                prevBestIndex[currentNumber] = prevBestPotentialIndex;
                numberPotential[currentNumber] = currentBestPotential;


            }
            //Console.WriteLine(string.Join(" ", numberPotential));
            //Console.WriteLine(string.Join(" ", prevBestIndex));
            int topNumber = 0;
            int IndexTopNumber = 0;
            for (int i = 0; i < numberPotential.Length; i++)
            {
                if (numberPotential[i] > topNumber)
                {
                    topNumber = numberPotential[i];
                    IndexTopNumber = i;
                }
            }
            //Console.WriteLine(topNumber);
            //Console.WriteLine(IndexTopNumber);

            int index = IndexTopNumber;
            int[] output = new int[topNumber];

            while (index != -1)
            {
                int currentNumber = input[index];
                output[topNumber -1] = currentNumber;
                index = prevBestIndex[index];
                topNumber--;
            }
            output.Reverse();
            Console.WriteLine(string.Join(" ", output));

        } 
    }
}
