int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int totalPieces = a * b *c;
bool isOver = false;
string input = Console.ReadLine();

while (input != "Done")
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
    Console.WriteLine($"No more free space! You need {Math.Abs(totalPieces)} Cubic meters more.");
}
else
    Console.WriteLine($"{totalPieces} Cubic meters left.");