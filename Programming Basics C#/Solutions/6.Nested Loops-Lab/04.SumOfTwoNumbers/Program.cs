

// Read Input

int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int magic = int.Parse(Console.ReadLine());

// Calculations

int counter  = 0;
bool isFound = false;

for (int i = x; i <= y; i++)
{
	for (int j = x; j <= y; j++)
	{
        counter++;
        if (i + j == magic)
		{
			
			isFound = true;
            Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magic})");
            break;
		}
		
	}
    if (isFound) break;
}

if (!isFound) Console.WriteLine($"{counter} combinations - neither equals {magic}");
