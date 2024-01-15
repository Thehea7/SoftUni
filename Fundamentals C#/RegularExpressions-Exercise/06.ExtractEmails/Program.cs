using System.Text.RegularExpressions;

namespace _06.ExtractEmails
{
    internal class Program
    {
        static void Main()
        {
            Regex emailpRegex = new Regex(@"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)(@)([a-zA-Z]+([\.\-][A-Za-z]+)+))(\b|(?=\s))");

            MatchCollection matches = emailpRegex.Matches(Console.ReadLine());

            foreach (Match match in matches)
            {
                
                Console.WriteLine(match.Value);
            }

        }
    }
}