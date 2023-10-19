
string result1 = Console.ReadLine();
string result2 = Console.ReadLine();    
string result3 = Console.ReadLine();
int won = 0;
int draw = 0;
int lost = 0;


if (result1[0] > result1[2]) won++;
else if (result1[0] == result1[2]) draw++;
else if (result1[0] < result1[2]) lost++;

if (result2[0] > result2[2]) won++;
else if (result2[0] == result2[2]) draw++;
else if (result2[0] < result2[2]) lost++;

if (result3[0] > result3[2]) won++;
else if (result3[0] == result3[2]) draw++;
else if (result3[0] < result3[2]) lost++;






// PrintOutput

Console.WriteLine($"Team won {won} games.");
Console.WriteLine($"Team lost {lost} games.");
Console.WriteLine($" Drawn games: {draw}");