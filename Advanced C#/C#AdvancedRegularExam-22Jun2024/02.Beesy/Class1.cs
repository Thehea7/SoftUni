//namespace Beesy
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int size = int.Parse(Console.ReadLine());

//            string[,] field = new string[size, size];

//            int energy = 15;
//            int collectedNectar = 0;

//            int beeRow = 0;
//            int beeCol = 0;

//            bool isRestored = false;
//            bool isHiveReached = false;

//            for (int i = 0; i < field.GetLength(0); i++)
//            {
//                string newRow = Console.ReadLine();

//                for (int j = 0; j < field.GetLength(1); j++)
//                {
//                    field[i, j] = newRow[j].ToString();

//                    if (field[i, j] == "B")
//                    {
//                        beeRow = i;
//                        beeCol = j;

//                        field[i, j] = "-";
//                    }
//                }
//            }

//            while (energy > 0 || field[beeRow, beeCol] != "H")
//            {
//                if (energy == 0)
//                {
//                    break;
//                }

//                string command = Console.ReadLine();

//                switch (command)
//                {
//                    case "up":
//                        beeRow--;
//                        break;
//                    case "down":
//                        beeRow++;
//                        break;
//                    case "left":
//                        beeCol--;
//                        break;
//                    case "right":
//                        beeCol++;
//                        break;
//                }

//                if (command == "up" || command == "down")
//                {
//                    if (beeRow < 0)
//                    {
//                        beeRow = size - 1;
//                    }
//                    else if (beeRow >= size)
//                    {
//                        beeRow = 0;
//                    }
//                }

//                if (command == "left" || command == "right")
//                {
//                    if (beeCol < 0)
//                    {
//                        beeCol = size - 1;
//                    }
//                    else if (beeCol >= size)
//                    {
//                        beeCol = 0;
//                    }
//                }

//                energy--;

//                if (field[beeRow, beeCol] == "-")
//                {
//                    if (energy == 0 && collectedNectar >= 30 && !isRestored)
//                    {
//                        energy = collectedNectar - 30;
//                        collectedNectar = 30;
//                        isRestored = true;
//                    }

//                    continue;
//                }

//                if (field[beeRow, beeCol] != "H")
//                {
//                    int currentFlower = int.Parse(field[beeRow, beeCol]);

//                    collectedNectar += currentFlower;
//                    field[beeRow, beeCol] = "-";

//                    if (energy == 0)
//                    {
//                        if (collectedNectar >= 30 && !isRestored)
//                        {
//                            energy = collectedNectar - 30;
//                            collectedNectar = 30;
//                            isRestored = true;
//                        }
//                        continue; ;
//                    }
//                }
//                else
//                {
//                    isHiveReached = true;
//                    break;
//                }
//            }

//            field[beeRow, beeCol] = "B";

//            if (energy == 0 && !isHiveReached)
//            {
//                Console.WriteLine($"This is the end! Beesy ran out of energy.");
//            }
//            else if (collectedNectar < 30)
//            {
//                Console.WriteLine($"Beesy did not manage to collect enough nectar.");
//            }
//            else
//            {
//                Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
//            }

//            for (int i = 0; i < field.GetLength(0); i++)
//            {
//                for (int j = 0; j < field.GetLength(1); j++)
//                {
//                    Console.Write(field[i, j]);
//                }

//                Console.WriteLine();
//            }
//        }
//    }
//}
