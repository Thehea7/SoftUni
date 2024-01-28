namespace _05.CountSymbols
{
    internal class Program
    {
        static void Main()
        {
            char[] input = Console.ReadLine().ToCharArray();
            Dictionary<char, int> charsDictionary = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (!charsDictionary.ContainsKey(c))
                {
                    charsDictionary.Add(c, 0);
                }

                charsDictionary[c]++;
            }

            foreach (var (character, occurance) in charsDictionary.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{character}: {occurance} time/s");
            }

        }
    }
}