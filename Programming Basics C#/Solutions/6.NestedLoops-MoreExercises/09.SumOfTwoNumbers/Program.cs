int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int counter = 0;
bool isFound = false;

for (int i = x; i <= y; i++)
{
	for (int k = x; k <= y; k++)
	{
		counter++;
		if (i + k == m)
		{
			isFound = true;
            Console.WriteLine($"Combination N:{counter} ({i} + {k} = {m})");
            break;
		}

	}
	if (isFound) break;
}
if (!isFound) Console.WriteLine($"{counter} combinations - neither equals {m}");

