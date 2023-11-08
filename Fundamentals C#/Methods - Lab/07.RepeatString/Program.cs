namespace _07.RepeatString
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine(ConcatenateString(count, input));
        }

        private static string ConcatenateString(int count, string? input)
        {
            string result = String.Empty;
            for (int i = 0; i < count; i++)
            {
                result += input;
            }
            return result;
        }
    }
}