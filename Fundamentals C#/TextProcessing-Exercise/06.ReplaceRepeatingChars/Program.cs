namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == input[i - 1])
                {
                   input = input.Remove(i, 1);
                   i--;
                }
            }
            Console.WriteLine(input);
        }
    }
}