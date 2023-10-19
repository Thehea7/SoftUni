


//Read Input

int n = int.Parse(Console.ReadLine());

//Calculations
int p = 0; // <200
int p1 = 0; // <400
int p2 = 0; // <600
int p3 = 0; // <800
int p4 = 0;//else

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber < 200) p++;
    else if (currentNumber < 400) p1++;
    else if (currentNumber < 600 ) p2++;
    else if (currentNumber < 800 ) p3++;    
    else p4++;
}
// Print Output

Console.WriteLine($"{100.0 * p / n:f2}%");
Console.WriteLine($"{100.0 * p1 / n:f2}%");
Console.WriteLine($"{100.0 * p2 / n:f2}%");
Console.WriteLine($"{100.0 * p3 / n:f2}%");
Console.WriteLine($"{100.0 * p4 / n:f2}%");