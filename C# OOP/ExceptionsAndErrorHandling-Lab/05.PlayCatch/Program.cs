
using System.Text;

List<int> input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int errors = 0;

while (errors < 3)
{
    string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string command = commands[0];
    try
    {
        switch (command)
        {
            case "Replace":
                Replace(commands);
                break;
            case "Print":
                Print(commands);
                break;
            case "Show":
                Show(commands);
                break;
        }
    }
    catch (ArgumentException e)
    {
        Console.WriteLine(e.Message);
        errors++;
    }
    catch (FormatException ex)
    {
        Console.WriteLine("The variable is not in the correct format!");
        errors++;
    }
    
}

Console.WriteLine(string.Join(", ", input));
void Show(string[] strings)
{
    int index = int.Parse(strings[1]);
    if (IndexIsValid(index))
    {
        Console.WriteLine(input[index]);
    }
}
void Print(string[] strings)
{
    int index1 = int.Parse(strings[1]);
    int index2 = int.Parse(strings[2]);

    if (IndexIsValid(index1) && IndexIsValid(index2))
    {
        List<int> result = input.GetRange(index1, index2 - index1 +1);
        Console.WriteLine(string.Join(", ", result));
    }
}
void Replace(string[] strings)
{
    int index = int.Parse(strings[1]);
    int element = int.Parse(strings[2]);
    if (IndexIsValid(index))
    {
        input[index] = element;
    }

}

bool IndexIsValid(int index)
{
    if (index < 0 || index >= input.Count)
    {
        throw new ArgumentException ("The index does not exist!");
    }

    return true;
}