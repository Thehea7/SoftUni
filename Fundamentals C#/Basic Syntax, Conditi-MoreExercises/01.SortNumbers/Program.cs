

int n1 = int.Parse(Console.ReadLine());
int n2 = int.Parse(Console.ReadLine());
int n3 = int.Parse(Console.ReadLine());


if (n1 < n2)
{
    int currentValue = n1;
    n1 = n2;
    n2 = currentValue;
}

if (n2 < n3)
{
    int currentValue = n2;
    n2 = n3;
    n3 = currentValue;
}

if (n1 < n2)
{
    int currentValue = n1;
    n1 = n2;
    n2 = currentValue;
}

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);