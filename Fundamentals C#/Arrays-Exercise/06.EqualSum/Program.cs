namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            bool isEqual = false;
            for (int i = 0; i < input.Length; i++)
            {
                
                int sumLeft = 0;
                int sumRight = 0;

                for (int j = 0; j < i; j++) 
                { 
                sumLeft += input[j];
                }
                for (int j = i +1; (j < input.Length); j++)
                {
                    sumRight += input[j];
                }
                if (sumLeft == sumRight)
                {
                    Console.Write($"{i} ");
                    isEqual = true;
                }
                
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }

        }
    }
}