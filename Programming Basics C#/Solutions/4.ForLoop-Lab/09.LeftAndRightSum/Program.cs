

//
int n = int.Parse(Console.ReadLine());

// Calculation
int sum1 = 0;
int sum2 = 0;

for (int i = 0; i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum1 += currentNumber;
}
for (int i = 0;i < n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());
    sum2 += currentNumber;
}

if (sum1 == sum2)
{
    Console.WriteLine($"Yes, sum = {sum1}");
}
else { Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}"); }