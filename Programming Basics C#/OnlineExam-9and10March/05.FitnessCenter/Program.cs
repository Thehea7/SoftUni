// Read Input

int visitors = int.Parse(Console.ReadLine());
int back = 0;
int chest = 0;
int legs = 0;
int abs = 0;
int proteinBar = 0;
int proteinShake = 0;
int peopleTraining = 0;
int peopleProtein = 0;

for  (int i = 0; i < visitors; i++)
{
    string activity = Console.ReadLine();
    if (activity == "Back")
    {
        back++;
        peopleTraining++;
    }
    else if (activity == "Chest")
    {
        chest++;
        peopleTraining ++;
    }
    else if(activity == "Legs")
    {
        legs++;
        peopleTraining++;  
    }
    else if (activity == "Abs")
    {
        abs++;
        peopleTraining++;
    }
    else if (activity == "Protein shake")
    {
        proteinShake++;
        peopleProtein++;
    }
    else if (activity == "Protein bar")
    {
        proteinBar++;
        peopleProtein ++;
    }
}

Console.WriteLine($"{back} - back");
Console.WriteLine($"{chest} - chest");
Console.WriteLine($"{legs} - legs");
Console.WriteLine($"{abs} - abs");
Console.WriteLine($"{proteinShake} - protein shake");
Console.WriteLine($"{proteinBar} - protein bar");
Console.WriteLine($"{100.00 * peopleTraining / visitors:f2}% - work out");
Console.WriteLine($"{100.00 * peopleProtein / visitors:f2}% - protein");