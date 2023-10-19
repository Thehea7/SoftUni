string input = Console.ReadLine();
string all = "";
int fighters = 0;
while (input != "rdy")
{
	string currentNumber = "";
	for (int i = 0; i < input.Length; i++)
	{

		if (input[i] >= 48 && input[i] <= 57)
		{
			currentNumber += input[i].ToString();
		}
		if (input[i] == 41)
		{
			currentNumber += ", ";
			fighters++;
		}
	}
	all += (currentNumber);

	input = Console.ReadLine();
}
all = all.Remove(all.Length - 2);
Console.WriteLine();
Console.WriteLine(all);
Console.WriteLine();
Console.WriteLine($"Total :{fighters} fighters");
Console.ReadLine();



