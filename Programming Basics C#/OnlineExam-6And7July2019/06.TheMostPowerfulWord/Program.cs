string glasna = "aAeEiIoOuUyY";
string mostPowerfullWord = "";
double highestPower = 0;
bool firstGlasna = false;

string input = Console.ReadLine();

while (input != "End of words")
{
    double points = 0;
    firstGlasna = false;
    for (int i = 0; i < input.Length; i++)
    {
        points += input[i];
        
    }
    for (int a = 0; a < glasna.Length; a++)
    {
        if (glasna[a] == input[0])
        {
            points *= input.Length;
            firstGlasna = true;
            break;
        }
    }
    if (!firstGlasna)
    {
        points = Math.Floor(1.0 * points / input.Length);
    }
    if (highestPower < points)
    {
        highestPower = points;
        mostPowerfullWord = input;
    }

    input = Console.ReadLine();
}

Console.WriteLine($"The most powerful word is {mostPowerfullWord} - {highestPower}");