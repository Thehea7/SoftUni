int n = int.Parse(Console.ReadLine());
int p1 = 0;
int p2 = 0;
int p3 = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber % 2 == 0) p1++;
    if (currentNumber % 3 == 0) p2++;
    if (currentNumber % 4 == 0)p3++;
}

Console.WriteLine($"{100.0 * p1/n:f2}%");
Console.WriteLine($"{100.0 * p2/n:f2}%");
Console.WriteLine($"{100.0 * p3/n:f2}%");
