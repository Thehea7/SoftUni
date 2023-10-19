string moovie = Console.ReadLine();
int seasons = int.Parse(Console.ReadLine());
int episodes  = int.Parse(Console.ReadLine());
double episodeLenght  = double.Parse(Console.ReadLine());

double totalTime = episodeLenght * episodes * seasons * 1.2 + 10 * seasons;

Console.WriteLine($"Total time needed to watch the {moovie} series is {Math.Floor(totalTime)} minutes.");