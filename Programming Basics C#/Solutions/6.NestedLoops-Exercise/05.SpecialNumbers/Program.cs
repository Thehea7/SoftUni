
// SOLUTION 1

//Read Input

//int n  = int.Parse(Console.ReadLine());

//for (int i = 1111; i < 9999; i++)
//{
//    int curentNumber = i;


//        int x1 = curentNumber % 10;
//        curentNumber /= 10;
//        int x2 = curentNumber % 10;
//        curentNumber /= 10;
//        int x3 = curentNumber % 10;
//        curentNumber /= 10;
//        int x4 = curentNumber % 10;

//        if (x1 == 0 || x2 == 0 || x3 == 0 || x4 == 0) continue;
//        else if (n % x1 ==0 &&  n % x2 == 0 && n % x3 == 0 && n % x4 == 0)
//        {
//            Console.Write($"{i} ");
//        }

//}

// solution 2


int n = int.Parse(Console.ReadLine());

for (int i = 1; i < 10; i++)
    for (int j = 1; j < 10; j++)
        for (int k = 1; k < 10; k++)
            for (int l = 1; l < 10; l++)
            {
                if (n % i == 0 && n % j == 0 && n % k == 0 && n % l == 0)
                    Console.Write($"{i}{j}{k}{l} ");
            }


