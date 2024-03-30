using System.Text;

StringBuilder sb = new StringBuilder(Console.ReadLine());

string commands;

while ((commands = Console.ReadLine()) != "Reveal")
{
    string[] arguments = commands.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

    string command = arguments[0];

    switch (command)
    {
        case "InsertSpace":
            InsertSpace(sb, arguments);
            break;
        case "Reverse":
            Reverse(sb, arguments);
            break;
        case "ChangeAll":
            ChangeAll(sb, arguments);
            break;
    }
}

Console.WriteLine($"You have a new text message: {sb}");

static void InsertSpace(StringBuilder sb, string[] arguments)
{
    int index = int.Parse(arguments[1]);
    sb.Insert(index, ' ');
    Console.WriteLine(sb);
}
static void Reverse(StringBuilder sb, string[] arguments)
{
    string substring = arguments[1];
    int index = sb.ToString().IndexOf(substring);

    if (index == -1)
    {
        Console.WriteLine("error");
        return;
    }

    sb.Remove(index, substring.Length);
    sb.Append(string.Join("", substring.Reverse()));
    Console.WriteLine(sb);
}

static void ChangeAll(StringBuilder sb, string[] arguments)
{
    string oldString = arguments[1];
    string newString = arguments[2];
    sb.Replace(oldString, newString);
    Console.WriteLine(sb);
}