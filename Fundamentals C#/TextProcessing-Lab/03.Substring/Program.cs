namespace _03.Substring
{
    internal class Program
    {
        static void Main()
        {
            string filter = Console.ReadLine();
            string word = Console.ReadLine();
            while (word.Contains(filter))
            {
               int index =  word.IndexOf(filter);
               word = word.Remove(index, filter.Length);
            }

            Console.WriteLine(word);
        }
    }
}