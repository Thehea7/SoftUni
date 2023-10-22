int kegs = int.Parse(Console.ReadLine());

string biggestModel = "";
double biggestVolume  = 0;

for (int i = 0; i < kegs; i++)
{
    string model = Console.ReadLine();
    double radius = double.Parse(Console.ReadLine());
    int heigh = int.Parse(Console.ReadLine());
    double currentVolume = Math.PI* Math.Pow(radius, 2) * heigh;
    if (currentVolume > biggestVolume)
    {
        biggestVolume = currentVolume;
        biggestModel = model;
    }
}
Console.WriteLine(biggestModel);