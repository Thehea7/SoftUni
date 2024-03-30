using System.Text.RegularExpressions;

string input = Console.ReadLine();

Regex  regex = new Regex(@"(=|\/)(?'Stop'[A-Z]{1}[A-Za-z]{2,})\1");

MatchCollection  matches = regex.Matches(input);
int totalPoints = 0;
List<string> destitantiions = new();
foreach (Match match in matches)
{
    destitantiions.Add(match.Groups["Stop"].Value);
    totalPoints += match.Groups["Stop"].Value.Length;
}

Console.WriteLine($"Destinations: {string.Join(", ", destitantiions)}");
Console.WriteLine($"Travel Points: {totalPoints}");
