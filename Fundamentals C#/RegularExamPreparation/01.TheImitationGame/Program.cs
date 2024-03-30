using System.Text;

StringBuilder sb =  new StringBuilder(Console.ReadLine());

string commands;

while ((commands = Console.ReadLine()) != "Decode")
{
    string[] arguments = commands.Split("|", StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];

    switch (command)
    {
        case "Move":
            int nLetters = int.Parse(arguments[1]);
            Move(sb, nLetters);
            break;
        case "Insert":
            int index = int.Parse(arguments[1]);
            string value = arguments[2];
            sb.Insert(index, value);
            break;
        case "ChangeAll":
            string substring = arguments[1];
            string replacement = arguments[2];
            sb.Replace(substring, replacement);
            break;
    }

}

Console.WriteLine($"The decrypted message is: {sb}");

static void Move(StringBuilder sb, int nLetters)
{
     string substring = sb.ToString().Substring(0, nLetters);
     sb.Remove(0, nLetters);
     sb.Append(substring);
}

