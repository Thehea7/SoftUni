namespace _04.FoldAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int multiplier = int.Parse(Console.ReadLine());

            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = input.Length / 4;

            int[] newArr = new int[input.Length / 2];
            for (int i = index - 1, j = 0; i >= 0 && j < index; i--, j++)
            {
                newArr[j] = input[i];
            }
            for (int i = input.Length - 1, j = index; i >= 3*index && j < index *2; i--, j++)
            {
                newArr[j] = input[i];
            }
            int[] newArr2 = new int[input.Length / 2];
            for (int i = 0, j = index; i < newArr2.Length && j < 3*index; i++, j++)
            {
                newArr2[i] = input[j];
            }
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write($"{newArr[i] + newArr2[i]} ");
            }

        }
    }
}