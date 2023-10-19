

//Read Input

int n = int.Parse(Console.ReadLine());

//Calculation

int sumOdd = 0;
int sumEven = 0;

for (int i = 1; i <= n; i++)
{
    int currentNumber = int.Parse(Console.ReadLine());

    if (i % 2 == 0) { sumEven += currentNumber; }
    else { sumOdd += currentNumber; }

}

// Print Output

if (sumEven == sumOdd)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sumOdd}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(sumOdd -sumEven)}");
}