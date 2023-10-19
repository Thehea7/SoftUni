int monet1 = int.Parse(Console.ReadLine());
int monet2  = int.Parse(Console.ReadLine());
int piece5  = int.Parse(Console.ReadLine());
int amount  = int.Parse(Console.ReadLine());


for (int i = 0; i <= monet1; i++)  
    for (int j = 0; j <= monet2; j++)
        for (int k = 0; k <= piece5; k++)
        {
            if (i +  (j*2) + (k*5) == amount)
            {
                Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {amount} lv.");
            }

        }
