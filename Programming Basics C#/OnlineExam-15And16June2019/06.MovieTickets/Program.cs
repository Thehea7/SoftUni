
int a1 = int.Parse(Console.ReadLine());
int a2 = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());


for (int i = a1; i < a2; i++)
{
    for (int j = 1; j < n; j++)
    {
        for (int k = 1; k < (n / 2); k++)
        {
            if (i %2 != 0 && (i + j + k) %2 != 0)
            {
                Console.WriteLine($"{(char)i}-{j}{k}{i}");

            }
            
        }
    }
}

