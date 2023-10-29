namespace _04.ArrayRotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                string[] newArr = new string[input.Length];
                newArr[input.Length -1] = input[0];
                for (int j = 0; j < input.Length -1; j++)
                {
                    newArr[j] = input[j +1];
                }
                for (int k = 0; k < input.Length; k++)
                {
                    input[k] = newArr[k];
                }
            }
            foreach (var number in input)
            {
                Console.Write($"{number} ");
            }
        }
    }
}