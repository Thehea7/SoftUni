using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main()
        {
            string regex = @"(?<Day>\d{2})(.|-|/)(?'Month'[A-Z][a-z]{2})\1(?'Year'\d{4})\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["Day"]}, Month: {match.Groups["Month"]}, Year: {match.Groups["Year"]}");
            }
        }
    }
}