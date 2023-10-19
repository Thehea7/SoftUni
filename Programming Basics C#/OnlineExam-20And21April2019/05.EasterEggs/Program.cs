

int eggs = int.Parse(Console.ReadLine());
int redEggs = 0;
int orangeEggs = 0;
int blueEggs = 0;
int greenEggs = 0;
int maxEggs = 0;
string maxEggColor = "";

for (int i = 0; i < eggs; i++)
{
    string color = Console.ReadLine();
    if (color == "red")
    {
        redEggs++;
        if (redEggs > maxEggs)
        {
            maxEggs = redEggs;
            maxEggColor = "red";
        }
    }
    else if (color == "orange")
    {
        orangeEggs++;
        if(orangeEggs > maxEggs)
        {
            maxEggs = orangeEggs;
            maxEggColor = "orange";
        }
            
    }
    else if(color == "blue")
    {
        blueEggs++;
        if (blueEggs > maxEggs)
        {
            maxEggs = blueEggs;
            maxEggColor = "blue";
        }
    }
    else if (color == "green")
    {
        greenEggs++;
        if (greenEggs > maxEggs)
        {
            maxEggs = greenEggs;
            maxEggColor = "green";
        }
            
    }


}

Console.WriteLine($"Red eggs: {redEggs}");
Console.WriteLine($"Orange eggs: {orangeEggs}");
Console.WriteLine($"Blue eggs: {blueEggs}");
Console.WriteLine($"Green eggs: {greenEggs}");
Console.WriteLine($"Max eggs: {maxEggs} -> {maxEggColor}");
