namespace _03.CharactersIRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
          char a = char.Parse(Console.ReadLine());
          char b = char.Parse(Console.ReadLine());

          PrintCharsInBewteen(a, b);
            
        }

        private static void PrintCharsInBewteen(char a, char b)
        {

            if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
            else
            {
                for (int i = b + 1; i < a; i++)
                {
                    Console.Write($"{(char)i} ");
                }
            }
        }
    }
}