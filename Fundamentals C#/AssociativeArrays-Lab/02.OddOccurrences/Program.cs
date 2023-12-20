namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .ToArray();

            Dictionary<string, int> words = new Dictionary<string, int>();

            foreach (var word in input)
            {
                if (!words.ContainsKey(word))
                {
                    words.Add(word, 0);
                }
                words[word]++;
            }

            foreach (var pairWord in words)
            {
                if (pairWord.Value % 2 != 0)
                {
                    Console.Write($"{pairWord.Key} ");
                }
            }
        }
    }
}