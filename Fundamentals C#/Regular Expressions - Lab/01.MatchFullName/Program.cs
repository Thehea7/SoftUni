using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    internal class Program
    {
        static void Main()
        {
            string regex = @"\b(?<FirstName>[A-Z][a-z]+) \b(?<LastName>[A-Z][a-z]+)";

            string names = Console.ReadLine();

            MatchCollection matches = Regex.Matches(names, regex);

            foreach (Match match in matches)
            {
                Console.Write($"{match.Groups["FirstName"]} {match.Groups["LastName"]} ");
            }
        }
    }
}