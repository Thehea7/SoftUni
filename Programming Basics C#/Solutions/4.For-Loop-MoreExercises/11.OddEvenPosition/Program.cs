

using System;

int n = int.Parse(Console.ReadLine());

double oddSum = 0;
double oddMin = double.MaxValue;
double oddMax = double.MinValue;
double evenSum = 0;
double evenMin = double.MaxValue;
double evenMax = double.MinValue;

for (int i = 1; i <= n; i++)
{
    double curentNumber = double.Parse(Console.ReadLine());

    if (i % 2  == 0)
    {
        evenSum += curentNumber;
        if (curentNumber >evenMax) evenMax = curentNumber;
        if (curentNumber < evenMin) evenMin = curentNumber;
    }
    else
    {
        oddSum += curentNumber;
        if (curentNumber > oddMax) oddMax = curentNumber;
        if(curentNumber < oddMin) oddMin = curentNumber;
    }

}
if (oddMax == double.MinValue && evenMax == double.MinValue)
{
    Console.WriteLine($"OddSum={oddSum:f2},");
    Console.WriteLine($"OddMin=No,");
    Console.WriteLine($"OddMax=No,");
    Console.WriteLine($"EvenSum={evenSum:f2},");
    Console.WriteLine($"EvenMin=No,");
    Console.WriteLine($"EvenMax=No");
}
else if (oddMax == double.MinValue)
{
    Console.WriteLine($"OddSum={oddSum:f2},");
    Console.WriteLine($"OddMin=No,");
    Console.WriteLine($"OddMax=No,");
    Console.WriteLine($"EvenSum={evenSum:f2},");
    Console.WriteLine($"EvenMin={evenMin:f2},");
    Console.WriteLine($"EvenMax={evenMax:f2}");
}
else if (evenMin == double.MaxValue)
{
    Console.WriteLine($"OddSum={oddSum:f2},");
    Console.WriteLine($"OddMin={oddMin:f2},");
    Console.WriteLine($"OddMax={oddMax:f2},");
    Console.WriteLine($"EvenSum={evenSum:f2},");
    Console.WriteLine($"EvenMin=No,");
    Console.WriteLine($"EvenMax=No");
}
else
{
    Console.WriteLine($"OddSum={oddSum:f2},");
    Console.WriteLine($"OddMin={oddMin:f2},");
    Console.WriteLine($"OddMax={oddMax:f2},");
    Console.WriteLine($"EvenSum={evenSum:f2},");
    Console.WriteLine($"EvenMin={evenMin:f2},");
    Console.WriteLine($"EvenMax={evenMax:f2}");
}

