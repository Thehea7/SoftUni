using System.Text;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");
            StringBuilder validNames = new StringBuilder();

            foreach (string userName in input)
            {
                if (userName.All(x => char.IsDigit(x)
                               || char.IsLetter(x)
                               || x == '_'
                               || x == '-')
                    && userName.Length >= 3
                    && userName.Length <= 16)
                {
                    validNames.Append($"{userName}\n");
                }
            }

            Console.WriteLine(validNames);

        }
    }
}