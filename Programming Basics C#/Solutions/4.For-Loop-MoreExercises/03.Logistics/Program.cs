

// Read Input

int nLoads  = int.Parse(Console.ReadLine());

//calculations

int tonsInBus = 0;
int tonsInTruck = 0;
int tonsInTrain = 0;
//double totalWeight = 0;
double totalPrice = 0;

for (int i = 0; i < nLoads; i++)
{
    int currentLoad = int.Parse(Console.ReadLine());
  
    if (currentLoad < 4)
    {
        tonsInBus += currentLoad;
        totalPrice += (currentLoad * 200);
    }
    else if (currentLoad < 12)
    {
        tonsInTruck += currentLoad;
        totalPrice += (currentLoad * 175);
    }
    else
    {
        tonsInTrain += currentLoad;
        totalPrice += (currentLoad * 120);
    }

}

int totalWeight = tonsInBus + tonsInTruck + tonsInTrain;
// Print Output

Console.WriteLine($"{totalPrice / totalWeight:f2}");
Console.WriteLine($"{100.00 * tonsInBus / totalWeight:f2}%");
Console.WriteLine($"{100.00 * tonsInTruck / totalWeight:f2}%");
Console.WriteLine($"{100.00 * tonsInTrain / totalWeight:f2}%");