namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int lastMaxIndex = 0;
            int maxSequence = 1;
            int currentSequence = 1;
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    currentSequence = 1;
                }
                else
                {
                    currentSequence++;
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                        lastMaxIndex = i;
                    }
                }
            }
            for (int i = lastMaxIndex; i > lastMaxIndex - maxSequence; i--)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}