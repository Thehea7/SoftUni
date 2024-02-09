using System.Data;

namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] allId = Console.ReadLine().Split(",");

            Dictionary<string, int> Idictionary = new Dictionary<string, int>();

            foreach (string id in allId)
            {
                if (!Idictionary.ContainsKey(id))
                {
                    Idictionary.Add(id, 0);
                }

                Idictionary[id]++;
            }

            foreach (var (ID, count) in Idictionary)
            {
                if (count > 1)
                {
                    Console.Write($"{ID},");
                }
            }
        }
    }
}