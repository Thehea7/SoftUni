using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                output.Append((char)(input[i]+3));
            }
            Console.WriteLine(output);
        }
    }
}