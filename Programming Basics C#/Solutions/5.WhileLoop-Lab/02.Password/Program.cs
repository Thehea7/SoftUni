

// Read Input

string user = Console.ReadLine();
string password  = Console.ReadLine();
string input = Console.ReadLine();
//cycle

while (input != password)
{
    input = Console.ReadLine();
}
Console.WriteLine($"Welcome {user}!");