


string input = Console.ReadLine();
int minNumber = int.MaxValue;
int currentNumber = 0;
while (input != "Stop")
{
    currentNumber = int.Parse(input);
    if (currentNumber < minNumber) minNumber = currentNumber;
    input = Console.ReadLine();
}
Console.WriteLine(minNumber);