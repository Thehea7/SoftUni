
int n = int.Parse(Console.ReadLine());
int maxDifference = 0;
int lastPair = 0;


for (int i = 0; i < n; i++)
{
    int n1 = int.Parse(Console.ReadLine());
    int n2 = int.Parse(Console.ReadLine());
    int currentPair = n1 + n2;
    if (n == 1) Console.WriteLine($"Yes, value={currentPair}");
    else
    {
        if (Math.Abs(currentPair - lastPair) > maxDifference && i > 0) maxDifference = Math.Abs(currentPair - lastPair);
        lastPair = currentPair;
    }
}
if (maxDifference > 0) Console.WriteLine($"No, maxdiff={maxDifference}");
else if(n != 1) Console.WriteLine($"Yes, value={lastPair}");
