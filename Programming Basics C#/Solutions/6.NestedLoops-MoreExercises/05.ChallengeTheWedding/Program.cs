

using System.Diagnostics.Metrics;

int m = int.Parse(Console.ReadLine());
int w  = int.Parse(Console.ReadLine());
int tables = int.Parse(Console.ReadLine());
bool isOver = false;
int counter = 0;

for (int i = 1; i <= m; i++)
{
    for (int j = 1; j <= w; j++)
    {
        Console.Write($"({i} <-> {j}) ");
        counter ++;
        if ( counter == tables )
        {
            isOver = true;
            break;
        }
    }
    if (isOver) break; 
}

