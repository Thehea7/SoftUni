

int nMoovies = int.Parse(Console.ReadLine());
string moovie = "";
double rating = 0;
double totalRating = 0;
double maxRating = double.MinValue;
double minRating = double.MaxValue;
string moovieMin = "";
string moovieMax = "";

for (int i = 0; i < nMoovies; i++)
{
    moovie = Console.ReadLine();
    rating = double.Parse(Console.ReadLine());
    totalRating += rating;
    if (rating > maxRating)
    {
        maxRating = rating;
        moovieMax = moovie;
    }
    if (rating < minRating)
    {
        minRating = rating;
        moovieMin = moovie;

    }
}


Console.WriteLine($"{moovieMax} is with highest rating: {maxRating:f1}");
Console.WriteLine($"{moovieMin} is with lowest rating: {minRating:f1}");
Console.WriteLine($"Average rating: {totalRating / nMoovies:f1}");