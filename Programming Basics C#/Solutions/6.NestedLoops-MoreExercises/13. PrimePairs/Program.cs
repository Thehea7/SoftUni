

int start1 = int.Parse(Console.ReadLine());
int start2  = int.Parse(Console.ReadLine());

int limit1  = int.Parse(Console.ReadLine());
int limit2  = int.Parse(Console.ReadLine());
bool isprime1 = true;
bool isprime2 = true;

for (int i = 1; i <= 9; i++)
{
    for (int j = 0; j <= 9; j++)
    {
        for (int k = 1; k <= 9; k++)
        {
            for(int l = 0; l <= 9; l++)
            { 
                if (i*10 +j >= start1 && i*10 +j <= start1 +limit1 && k*10 +l >= start2 && k*10 +l <= start2 +limit2)
                {
                    for (int a = 2; a <= Math.Sqrt(i*10 +j); a++)
                    {
                        if ((i * 10 + j) % a == 0) isprime1 = false;
                    }
                    for (int b = 2; b <= Math.Sqrt(k * 10 + l); b++)
                    {
                        if ((k * 10 + l) % b == 0) isprime2 = false;
                    }
                    if (isprime1 && isprime2)
                    {
                        Console.WriteLine($"{i}{j}{k}{l}");
                    }
                    isprime1 = true;
                    isprime2 = true;
                }
            }
        }
    }
}