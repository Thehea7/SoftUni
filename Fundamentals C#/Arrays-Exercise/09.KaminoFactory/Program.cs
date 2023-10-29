namespace _09.KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string input = "";
            int maxSum = 0;
            int maxCount = 0;
            int minIndex = int.MaxValue;
            string bestDNA = "";
            int sampleCount = 0;
            int bestSampleCount = 0;
            bool isInputValid = false;
            while((input = Console.ReadLine()) != "Clone them!")
            {
                int sum = 0;
                int count = 0;
                int currentMaxCount = 0;
                int index = 0;
                sampleCount++;
                int[] currentInput = input.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (currentInput.Length != lenght ) 
                {
                    isInputValid = false;
                    break;
                }
                else isInputValid = true;
                for (int i = 0; i < lenght; i++)
                {
                    if (currentInput[i] == 1)
                    {
                        count++;
                        if (count > currentMaxCount)
                        {
                            
                            index = i;
                            currentMaxCount = count;

                        }

                    }
                    else
                    {
                        count = 0;
                    }
                    sum += currentInput[i];

                }
                if (currentMaxCount > maxCount)
                {
                    bestDNA = input;
                    maxCount = currentMaxCount;
                    minIndex = index;
                    maxSum = sum;
                    bestSampleCount = sampleCount;

                }
                else if (currentMaxCount == maxCount)
                {
                    if(index < minIndex)
                    {
                        bestDNA = input;
                        minIndex = index;
                        maxSum = sum;
                        bestSampleCount = sampleCount;
                    }
                    else if (index == minIndex)
                    {
                        if (sum > maxSum)
                        {
                            bestDNA = input;
                            maxSum = sum;
                            bestSampleCount = sampleCount;
                        }
                    }
                }
                
            }

            string[] output = bestDNA.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            //Output
            if (isInputValid )
            {
                Console.WriteLine($"Best DNA sample {bestSampleCount} with sum: {maxSum}.");
                Console.WriteLine(string.Join(" ", output));
            }
            
        }
    }
}