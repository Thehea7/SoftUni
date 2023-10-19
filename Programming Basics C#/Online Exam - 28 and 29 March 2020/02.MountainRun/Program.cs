double currentRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timeInSecondsPermeter  = double.Parse(Console.ReadLine());

double georgiTime = distance * timeInSecondsPermeter + 30 * Math.Floor(distance / 50);

if (georgiTime < currentRecord)
{
    Console.WriteLine($"Yes! The new record is {georgiTime:f2} seconds.");
}
else Console.WriteLine($"No! He was {georgiTime - currentRecord:f2} seconds slower.");