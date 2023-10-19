

//Read Input

int n = int.Parse(Console.ReadLine());
int currentNumber = 1;

//
while (currentNumber <= n)
{
    Console.WriteLine(currentNumber);
    currentNumber = currentNumber * 2 + 1;
}