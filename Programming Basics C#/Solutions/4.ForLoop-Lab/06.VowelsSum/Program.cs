// Read Input

string text = Console.ReadLine();
//Cycle
int sum = 0;

for (int i = 0; i < text.Length; i++)
    if (text[i] == 'a') sum++;
    else if (text[i] == 'e') sum+= 2;
    else if (text[i] == 'i') sum += 3;
    else if (text[i] == 'o') sum += 4;
    else if (text[i] == 'u') sum += 5;

//Print Output
Console.WriteLine(sum);