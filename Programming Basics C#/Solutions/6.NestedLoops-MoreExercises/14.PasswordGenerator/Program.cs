

int n = int.Parse(Console.ReadLine());
int l  = int.Parse(Console.ReadLine());
char a = 'a';

for  (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= n; j++)
    {
        for (char k = 'a'; k < a+l; k++)
        {
            for (char m ='a'; m < a+l; m++)
            {
                for (int p = 2; p <= n; p++)
                {
                    if (p > i && p > j)
                    {
                        Console.Write($"{i}{j}{k}{m}{p} ");
                    }
                }
            }
        }
    }
}