using System.Numerics;

int count = int.Parse(Console.ReadLine());
BigInteger bestSnowballValue = 0;
int bestSnowballSnow = 0;
int bestSnowballTime = 0;
int bestSnowballQuality = 0;


for (int i = 0; i < count; i++)
{
    int snowballSnow = int.Parse(Console.ReadLine());
    int snowballTime = int.Parse(Console.ReadLine());
    int snowballQuality = int.Parse(Console.ReadLine());

    BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
    if (snowballValue > bestSnowballValue)
    {
        bestSnowballQuality = snowballQuality;
        bestSnowballSnow = snowballSnow;
        bestSnowballTime = snowballTime;
        bestSnowballValue = snowballValue;
    }
}

Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");