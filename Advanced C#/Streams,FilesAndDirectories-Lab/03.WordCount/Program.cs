namespace WordCount
{
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            using (StreamReader filter = new StreamReader(wordsFilePath))
            {
                string[] words = filter.ReadToEnd().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                foreach (string word in words)
                {
                    wordCounts.Add(word.ToLower(), 0);
                }
            }

            using (StreamReader reader = new StreamReader(textFilePath))
            {
                string[] text = reader.ReadToEnd()
                    .Split(new [] { ' ', '.', ',', '?', '!', '-' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var str in text)
                {
                    if (wordCounts.ContainsKey(str.ToLower()))
                    {
                        wordCounts[str.ToLower()]++;
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                foreach (var (word, Count) in wordCounts.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{word} - {Count}");
                }
            }
            
        }
    }
}