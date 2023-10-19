

// REad Input

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

// Calculations
bool isOdd = false;


for  (int i = x; i >= x & i <= y; i++)
{
    int oddSum = 0;
    int evenSum = 0;
    int currentNumber = i;
    while (currentNumber > 0)
    {
        int digit = currentNumber % 10;
        if (isOdd) { oddSum += digit; }
        else { evenSum += digit; }
        currentNumber /= 10;
        isOdd = !isOdd;
    }
    if (oddSum == evenSum) Console.Write($"{i} ");

}