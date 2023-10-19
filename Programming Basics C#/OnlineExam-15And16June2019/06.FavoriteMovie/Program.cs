string bestFilm = "";
int maxPoints = 0;
int i = 0;
for  ( i = 0; i < 7; i++)
{
    string moovie = Console.ReadLine();
    if (moovie == "STOP") break;
    int currentPoints = 0;
    for (int j = 0; j < moovie.Length; j++)
    {
        currentPoints += moovie[j]; 
        for (char a = 'a'; a <= 'z'; a++)
        {
            if (moovie[j] == a) { currentPoints -= (2 * moovie.Length); }
        }
        for (char A = 'A';  A <= 'Z'; A++) 
        { 
            if (moovie[j] == A)  currentPoints -= moovie.Length;
        }
    }
    if (currentPoints > maxPoints)
    {
        maxPoints = currentPoints;
        bestFilm = moovie;
    }
}   

if (i == 7)
{
    Console.WriteLine("The limit is reached.");
}
Console.WriteLine($"The best movie for you is {bestFilm} with {maxPoints} ASCII sum.");