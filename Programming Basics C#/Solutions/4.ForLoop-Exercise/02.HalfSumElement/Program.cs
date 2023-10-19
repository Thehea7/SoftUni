


// REadInput

int n = int.Parse(Console.ReadLine());
int maxN = int.MinValue;
int totalSum = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    if (currentNumber > maxN) maxN = currentNumber;
    totalSum += currentNumber;
}
int sum = totalSum - maxN;// namirame sumata bez maxNumber



// Print Output
if (sum - maxN == 0)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sum - maxN)}");
}