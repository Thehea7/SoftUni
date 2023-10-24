int key = int.Parse(Console.ReadLine());
int nLines = int.Parse(Console.ReadLine());
string output = string.Empty;

for (int i = 0; i < nLines; i++)
{
    char currentdigit = char.Parse(Console.ReadLine());
    output += (char)(currentdigit + key);
}

Console.WriteLine(output);