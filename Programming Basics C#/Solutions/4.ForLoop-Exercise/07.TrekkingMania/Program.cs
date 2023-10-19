


//Read Input

int n = int.Parse(Console.ReadLine());

//Calculations
int p = 0; // <6
int p1 = 0; // <13
int p2 = 0; // <26
int p3 = 0; // <41
int p4 = 0;//else
int climbers = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    climbers += currentNumber;
    if (currentNumber < 6) p+=currentNumber;
    else if (currentNumber < 13) p1+=currentNumber;
    else if (currentNumber < 26) p2 += currentNumber;
    else if (currentNumber < 41) p3 += currentNumber;
    else p4 += currentNumber;
}
// Print Output

Console.WriteLine($"{100.0 * p / climbers:f2}%");
Console.WriteLine($"{100.0 * p1 / climbers:f2}%");
Console.WriteLine($"{100.0 * p2 / climbers:f2}%");
Console.WriteLine($"{100.0 * p3 / climbers:f2}%");
Console.WriteLine($"{100.0 * p4 / climbers:f2}%");