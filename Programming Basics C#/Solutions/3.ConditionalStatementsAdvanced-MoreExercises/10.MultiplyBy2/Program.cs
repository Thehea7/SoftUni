double i = double.Parse(Console.ReadLine());

while (i >= 0)
{
    Console.WriteLine($"Result: {i*2:f2}");
    i = double.Parse(Console.ReadLine());
}
Console.WriteLine("Negative number!");