using System.Text.RegularExpressions;

string input = Console.ReadLine();
Regex regex = new Regex(@"(#|\|)(?'name'[A-Za-z ]+)\1(?'date'\d{2}/\d{2}/\d{2})\1(?'calories'\d{1,5})\1");

MatchCollection  matches = regex.Matches(input);

int totalCalories = 0;

foreach (Match match in matches)
{
    totalCalories += int.Parse(match.Groups["calories"].Value);
}
int fullDays = totalCalories  / 2000;

Console.WriteLine($"You have food to last you for: {fullDays} days!");

foreach (Match match in matches)
{
    Console.WriteLine($"Item: {match.Groups["name"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
}