int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int totalPieces = a * b;
bool isOver = false;
string input = Console.ReadLine();

while (input != "STOP")
{
    int piecesTaken = int.Parse(input);
    totalPieces -= piecesTaken;
    if (totalPieces <= 0)
    {
        isOver = true;
        break;
    }
    input = Console.ReadLine();
}
if (isOver)
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
}
else
Console.WriteLine($"{totalPieces} pieces are left.");