double number1  = double.Parse(Console.ReadLine());
double number2  = double.Parse(Console.ReadLine());

bool isEqual = (Math.Abs(number1 - number2) < 0.000001);

Console.WriteLine(isEqual);