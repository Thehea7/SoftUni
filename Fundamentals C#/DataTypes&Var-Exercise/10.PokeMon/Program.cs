int pokePower = int.Parse(Console.ReadLine());
int distanceBetweenTargets = int.Parse(Console.ReadLine());
int fatigue = int.Parse(Console.ReadLine());
int targetsPoked = 0;
int pokePowerLeft = pokePower;

while (pokePowerLeft >= distanceBetweenTargets)
{
    pokePowerLeft -= distanceBetweenTargets;
    targetsPoked++;


    if (pokePowerLeft == 0.5 * pokePower)
    {
        if (fatigue != 0)
        {
            pokePowerLeft /= fatigue;
        }
    }

}



Console.WriteLine(pokePowerLeft);
Console.WriteLine(targetsPoked);