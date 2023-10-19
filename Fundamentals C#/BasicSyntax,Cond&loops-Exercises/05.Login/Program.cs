string name = Console.ReadLine();

//string password = new string (name.Reverse().ToArray());
string password = "";
for (int i = name.Length - 1; i >= 0; i--)
{
    password += name[i];
}

string login = Console.ReadLine();
int attempts = 0;
while (login != password)
{
    
    attempts++;
    if (attempts == 4)
    {
        Console.WriteLine($"User {name} blocked!");
        break;
    }
    Console.WriteLine("Incorrect password. Try again.");
    login = Console.ReadLine();
}

if (login == password) Console.WriteLine($"User {name} logged in.");