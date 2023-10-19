int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());  
int sum = 0;

for (int i = x; i <= y; i++)
{
    Console.Write($"{i} ");
    sum += i;
}
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");