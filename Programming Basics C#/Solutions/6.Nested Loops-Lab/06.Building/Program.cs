﻿

// Read Input

int floors = int.Parse(Console.ReadLine());
int rooms  = int.Parse(Console.ReadLine());

//calculations
for (int f = floors; f > 0; f--)
{
	for (int r = 0; r < rooms; r++)
	{
        if (f == floors)
        {
            Console.Write($"L{f}{r} ");
        }
        else if (f % 2 == 0)
        {
            Console.Write($"O{f}{r} ");
        }
        else
        {
            Console.Write($"A{f}{r} ");
        }
    }
    Console.WriteLine();
}