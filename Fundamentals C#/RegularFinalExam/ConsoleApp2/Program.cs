using System.Text.RegularExpressions;

int entries = int.Parse(Console.ReadLine());

Regex regex = new Regex(@"\|(?'name'[A-Z]{4,})\|:#(?'title'[A-Za-z]+ [A-Za-z]+)#");

for (int i = 0; i < entries; i++)
{
    string input = Console.ReadLine();
    if (regex.IsMatch(input))
    {
        Match match = regex.Match(input);
        string name = match.Groups["name"].Value;
        string title = match.Groups["title"].Value;

        Console.WriteLine($"{name}, The {title}");
        Console.WriteLine($">> Strength: {name.Length}");
        Console.WriteLine($">> Armor: {title.Length}");
    }
    else
    {
        Console.WriteLine("Access denied!");
    }

    
}