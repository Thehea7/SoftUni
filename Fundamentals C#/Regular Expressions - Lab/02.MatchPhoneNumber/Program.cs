using System.Text.RegularExpressions;
using Microsoft.VisualBasic;

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main()
        {
            string regex = @"\+359( |-)2\1\d{3}\1\d{4}\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            string[] output = matches
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();



            Console.WriteLine(string.Join(", ", output));
        }
    }
}