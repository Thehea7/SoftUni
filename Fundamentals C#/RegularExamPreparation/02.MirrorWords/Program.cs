using System;
using System.Text.RegularExpressions;

string input = Console.ReadLine();

Regex  regex = new Regex(@"(#|@)(?'word1'[A-Za-z]{3,})\1\1(?'word2'[A-Za-z]{3,})\1");

MatchCollection  matches = regex.Matches(input);

int validPairs = 0;
int mirroredPairs = 0;
List<string> mirroredPairsList = new List<string>();


foreach (Match match in matches)
{
    if (match.Groups["word1"].Value == string.Join("", match.Groups["word2"].Value.Reverse()))
    {
        string pair = $"{match.Groups["word1"].Value} <=> {match.Groups["word2"].Value}";
        mirroredPairsList.Add(pair);
        mirroredPairs++;
    }
}

if (matches.Count == 0)
{
    Console.WriteLine("No word pairs found!");
}
else
{
    Console.WriteLine($"{matches.Count} word pairs found!");
}

if (mirroredPairs == 0)
{
    Console.WriteLine("No mirror words!");
}
else
{
    Console.WriteLine("The mirror words are:");
    Console.WriteLine(string.Join(", ", mirroredPairsList));
    
}