namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main()
        {
            string input = string.Join("", Console.ReadLine().Split().ToArray());

            Dictionary<char, int> lettersCount = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char x = input[i];
                if (!lettersCount.ContainsKey(x))
                {
                    lettersCount.Add(x, 0);
                }
                lettersCount[x]++;
            }

            foreach (var letter in lettersCount)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}