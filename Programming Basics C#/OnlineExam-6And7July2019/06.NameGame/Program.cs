string name = Console.ReadLine();

int winnerPoints = 0;
string winner = "";




while (name != "Stop")
{
    int points = 0;
    for (int i = 0; i < name.Length; i++)
    {
        int currentNumber = int.Parse(Console.ReadLine());
        if (name[i] == currentNumber)
        {
            points += 10;
        }
        else points += 2;
        if (points >= winnerPoints)
        {
            winnerPoints = points;
            winner = name;
        }
    }
    name = Console.ReadLine();
}


Console.WriteLine($"The winner is {winner} with {winnerPoints} points!");