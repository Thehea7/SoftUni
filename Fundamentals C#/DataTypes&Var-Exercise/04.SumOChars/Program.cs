int n = int.Parse(Console.ReadLine());

int totalSum = 0;

for (int i = 0; i < n; i++)
{
    char a = char.Parse(Console.ReadLine()) ;
    totalSum += a ;
}

Console.WriteLine($"The sum equals: {totalSum}");