namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            Random rand = new Random();
            
            for (int i = 0; i < input.Length; i++)
            {
                int random = rand.Next(input.Length);
                string currentWord = input[i];
                string randomWord = input[random];

                input[i] = randomWord;
                input[random] = currentWord;
            }
            Console.WriteLine(string.Join("\n", input));
        }
    }
}