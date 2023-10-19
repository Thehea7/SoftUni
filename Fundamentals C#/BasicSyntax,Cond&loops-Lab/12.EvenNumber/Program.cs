int number = int.Parse(Console.ReadLine());
bool isEven = number % 2 == 0;

while (!isEven)
{
    Console.WriteLine("Please write an even number.");
    number = int.Parse(Console.ReadLine());
    isEven = number % 2 == 0;
}
if (isEven) Console.WriteLine($"The number is: {Math.Abs(number)}");
