
int n1 = int.Parse(Console.ReadLine());
int n2  = int.Parse(Console.ReadLine());   
int n3  = int.Parse(Console.ReadLine());
bool conditionsMet = false;


for (int i = 2; i <= n1; i++)
    for (int j = 2; j <= n2; j++)    
        for (int k = 2; k <= n3; k++)
        {
            if (i % 2 == 0 && k % 2 == 0)
            {
                bool isPrime = true;
                for (int l = 2; l < 7; l++)
                {
                    if (j % l == 0 && j != l) isPrime = false;


                }
                if (isPrime) Console.WriteLine($"{i} {j} {k}");

                
                
                
                
            }
        }