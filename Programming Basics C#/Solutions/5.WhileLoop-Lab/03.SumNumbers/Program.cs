

//REadInput

int sum = int.Parse(Console.ReadLine());
int number = int.Parse(Console.ReadLine());

while (sum > number)
{
    int currentNumber = int.Parse(Console.ReadLine());
    number += currentNumber;
}
Console.WriteLine(number);