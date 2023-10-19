
using System.Diagnostics.Metrics;

char lastSector = Console.ReadLine()[0];
int rowsA = int.Parse(Console.ReadLine());
int oddRowSeats  = int.Parse(Console.ReadLine());
int counter = 0;
int totalSeats =0;


for (char i = 'A'; i <= lastSector; i++)
{
	for (int rows = 1; rows <= rowsA; rows++)
	{
		if (rows % 2 != 0)
		{
			for (char seat = 'a'; seat <= 'z'; seat++)
			{
                Console.WriteLine($"{i}{rows}{seat}");
				totalSeats++;
				counter++;
				if (counter == oddRowSeats)
				{
					counter = 0;
					break;
				}
            }
		}
		else
		{
            for (char seat = 'a'; seat <= 'z'; seat++)
            {
                Console.WriteLine($"{i}{rows}{seat}");
				totalSeats++;
				counter++;
                if (counter == (oddRowSeats +2))
                {
                    counter = 0;
                    break;
                }
            }
        }

	}
	rowsA++;
}
Console.WriteLine(totalSeats);