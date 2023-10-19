


string input = Console.ReadLine();
int maxNumber = int.MinValue;
int currentNumber = 0;
while (input != "Stop")
{
    currentNumber = int.Parse(input);
    if (currentNumber > maxNumber) maxNumber = currentNumber;
    input = Console.ReadLine();
}
Console.WriteLine(maxNumber);