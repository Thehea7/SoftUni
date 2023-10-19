

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());  
int limit = int.Parse(Console.ReadLine());
char A = (char)35;
bool isOver = false;
char B = (char)64;
int counter = 0;

for (int x = 1; x <= a; x++)
{
    for (int y = 1; y <= b; y++)
    {
        
        
        Console.Write($"{A}{B}{x}{y}{B}{A}|");
        counter++;
        if (counter == limit)
        {
            isOver = true; break;
        }
       
        A++;
        B++;
        if (A == (char)56) A = (char)35;
        if (B == (char)97) B = (char)64;
    }
    if (isOver) break;
}







