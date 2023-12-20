namespace _03.WordSynonyms
{
    class Synonym
    {
        public string Name { get; set; }

        public List<string> Synonyms { get; set; }

        public Synonym(string name)
        {
            Name = name;

            Synonyms = new List<string>();
        }

        public override string ToString()
        {
            return $"{Name} - {string.Join(", ", Synonyms)}";
        }
    }
    internal class Program
    {
        static void Main()
        {
            int inputCount = int.Parse(Console.ReadLine());
            Dictionary<string, Synonym> dictionary = new Dictionary<string, Synonym>();

            for (int i = 0; i < inputCount; i++)
            {
                string name = Console.ReadLine();
                string synonym = Console.ReadLine();

                Synonym currentSynonym = new Synonym(name);

                if (!dictionary.ContainsKey(name))
                {
                    dictionary.Add(name, currentSynonym);
                }
                dictionary[name].Synonyms.Add(synonym);
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }
}