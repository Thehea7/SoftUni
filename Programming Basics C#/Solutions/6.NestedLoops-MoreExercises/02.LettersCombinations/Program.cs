

// Read Input


char start = Console.ReadLine()[0];
char end = Console.ReadLine()[0];
char exclude = Console.ReadLine()[0];
int combinations = 0;

// calculations

for (char i = start; i <= end; i++)
    for (char j = start; j <= end; j++)
        for (char k = start; k <= end; k++)
        {
            if (i != exclude && j != exclude && k != exclude)
            {
                Console.Write($"{i}{j}{k} ");
                combinations++;
            }
        }
Console.WriteLine(combinations);