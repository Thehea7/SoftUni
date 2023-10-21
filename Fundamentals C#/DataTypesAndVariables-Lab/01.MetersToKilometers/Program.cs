int distanceInMeters = int.Parse(Console.ReadLine());

double distanceInKilometards =distanceInMeters * 0.001;

Console.WriteLine($"{distanceInKilometards:f2}");