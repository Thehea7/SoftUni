int totalTime  = int.Parse(Console.ReadLine());
int picktures = int.Parse(Console.ReadLine());
int pickturesLenght  = int.Parse(Console.ReadLine());

double timeTaken = totalTime * 0.15 + picktures * pickturesLenght;

if (totalTime >= timeTaken)
{
    Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(totalTime - timeTaken)} minutes left!");
}
else Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(timeTaken - totalTime)} minutes.");