string input = Console.ReadLine();
int sum = 0;
for (int i = 0; i < input.Length; i++)
{
    int factorials = 1;
    int x = int.Parse(input[i].ToString());
    for (int j = 1; j <= x; j++)
    {
        factorials *= j;
        
    }
    sum += factorials;
}

if (sum == int.Parse(input))
{
    Console.WriteLine("yes");
}
else Console.WriteLine("no");