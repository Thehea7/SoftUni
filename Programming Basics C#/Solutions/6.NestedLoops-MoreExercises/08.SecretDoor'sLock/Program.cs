
int x1 = int.Parse(Console.ReadLine());
int x2  = int.Parse(Console.ReadLine());    
int x3 = int.Parse(Console.ReadLine());
bool isPrime = true;


for  (int i = 1; i <= x1; i++)   
    for (int j = 2; j <= x2; j++)
        for (int k = 1; k <= x3; k++)
        {
            for (int l = 2; l <= Math.Sqrt(j); l++)
            {
                if (j % l == 0) isPrime = false;
            }
            if (isPrime && i % 2 ==0 && k % 2 == 0)
            {
                Console.WriteLine($"{i} {j} {k}");
            }
            isPrime = true;
        }
           



