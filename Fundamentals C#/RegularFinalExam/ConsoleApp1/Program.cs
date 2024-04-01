using System.Diagnostics;
using System.Text;

StringBuilder sb = new StringBuilder(Console.ReadLine());

string commands;

while ((commands = Console.ReadLine()) != "Complete")
{
    string[] arguments = commands.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = arguments[0];

    switch (command)
    {

        case "Make":
            Make(sb, arguments);
            break;
        case "Insert":
            Insert(sb, arguments);
            break;
        case "Replace":
            Replace(sb, arguments);
            break;
        case "Validation":
            Validate(sb, arguments);
            break;

    }

}

static bool IsValid(StringBuilder sb, int index)
{
    if (index < 0 || index >= sb.Length)
    {
        return false;
    }

    return true;
}
static void Make(StringBuilder sb, string[] arguments)
{
    string command2 = arguments[1];
    int index = int.Parse(arguments[2]);
    if (IsValid(sb, index))
    {
        char a = sb[index];
        if (command2 == "Upper")
        {
            a = char.ToUpper(a);
            sb[index] = a;
            Console.WriteLine(sb);
        }

        if (command2 == "Lower")
        {
            a = char.ToLower(a);
            sb[index] = a;
            Console.WriteLine(sb);
        }
    }
}

static void Insert(StringBuilder sb, string[] arguments)
{
    int index = int.Parse(arguments[1]);
    string a = arguments[2];
    if (IsValid(sb, index))
    {
        sb.Insert(index, a);
        Console.WriteLine(sb);
    }
}
static void Replace(StringBuilder sb, string[] arguments)
{
    
    char oldChar = arguments[1][0];
    int value = int.Parse(arguments[2]);
    char newChar = (char)(oldChar + value);
    if (sb.ToString().Contains(oldChar))
    {
        sb.Replace(oldChar, newChar);
        Console.WriteLine(sb);
    }
}

static void Validate(StringBuilder sb, string[] arguments)
{
    if (sb.Length < 8)
    {
        Console.WriteLine("Password must be at least 8 characters long!");
    }
    bool hasUpper = false;
    bool hasLower = false;
    bool hasDigit = false;
    for (int i = 0; i < sb.Length; i++)
    {
        char a = sb[i];
        if (char.IsLetterOrDigit(a) == false && a != '_')
        {
            Console.WriteLine("Password must consist only of letters, digits and _!");
        }

        if (char.IsUpper(a))
        {
            hasUpper = true;
        }

        if (char.IsLower(a))
        {
            hasLower = true;
        }

        if (char.IsDigit(a))
        {
            hasDigit = true;
        }
        
    }
    if (hasUpper == false)
    {
        Console.WriteLine("Password must consist at least one uppercase letter!");
    }

    if (hasLower == false)
    {
        Console.WriteLine("Password must consist at least one lowercase letter!");
    }

    if (hasDigit == false)
    {
        Console.WriteLine("Password must consist at least one digit!");
    }

}