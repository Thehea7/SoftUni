using System.Globalization;
using System.Text;

StringBuilder sb = new StringBuilder(Console.ReadLine());

string commands;
while ((commands = Console.ReadLine()) != "Travel")
{
    string[] arguments = commands.Split(":", StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];

    switch (command)
    {
        case "Add Stop":
            AddStop(sb, arguments);
            break;
        case "Remove Stop":
            RemoveStop(sb, arguments);
            break;
        case "Switch":
            Switch(sb, arguments);
            break;
    }
}

Console.WriteLine($"Ready for world tour! Planned stops: {sb}");


static bool IsValid(StringBuilder sb, int index)
{
    if (index < 0
        || index >= sb.Length)
    {
        return false;
    }

    return true;
}

static void AddStop(StringBuilder sb, string[] arguments)
{
    int index = int.Parse(arguments[1]);
    string strToAdd = arguments[2];
    if (IsValid(sb, index))
    {
        sb.Insert(index, strToAdd);
    }

    Console.WriteLine(sb);
}

static void RemoveStop(StringBuilder sb, string[] arguments)
{
    int startIndex = int.Parse(arguments[1]);
    int endIndex = int.Parse(arguments[2]);
    if (IsValid(sb, startIndex) && IsValid(sb, endIndex))
    {
        sb.Remove(startIndex, (endIndex - startIndex) + 1);
    }

    Console.WriteLine(sb);
}

static void Switch(StringBuilder sb, string[] arguments)
{
    string oldString = arguments[1];
    string newString = arguments[2];
    sb.Replace(oldString, newString);
    Console.WriteLine(sb);
}