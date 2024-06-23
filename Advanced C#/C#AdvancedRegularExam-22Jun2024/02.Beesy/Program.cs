namespace _02.Beesy
{
    internal class Program
    {
        private static int nectar = 0;
        private static int x;
        private static int y;
        private static int energy = 15;
        private static bool recharged = false;
        private static bool isOver;

        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());
            char[][] matrix = new char[rows][];

            for (int i = 0; i < rows; i++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                matrix[i] = new char[currentRow.Length];
                for (int j = 0; j < currentRow.Length; j++)
                {
                    matrix[i][j] = currentRow[j];
                }
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (matrix[i][j] == 'B')
                    {
                        x = i; y = j;
                    }
                }
            }

            while (isOver is false)
            {
                energy--;
                
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        Up(matrix);
                        break;
                    case "down":
                        Down(matrix);
                        break;
                    case "left":
                        Left(matrix);
                        break;
                    case "right":
                        Right(matrix);
                        break;
                }
                if (isOver ) break;
                CheckEnergy();
                if(isOver) break;
                CheckEnergy();


            }

            PrintMatrix(rows, matrix);
        }

        private static void Right(char[][] matrix)
        {
            matrix[x][y] = '-';
            y++;
            if (y >= matrix.GetLength(0))
            {
                y = 0;
            }

            CheckNewPosition(matrix);
        }

        private static void Left(char[][] matrix)
        {
            matrix[x][y] = '-';
            y--;
            if (y < 0)
            {
                y = matrix.GetLength(0)-1;
            }

            CheckNewPosition(matrix);
        }

        private static void Down(char[][] matrix)
        {
            matrix[x][y] = '-';
            x++;
            if (x >= matrix.GetLength(0))
            {
                x = 0;
            }

            CheckNewPosition(matrix);
        }

        private static void PrintMatrix(int rows, char[][] matrix)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(matrix[i][j]);
                }

                Console.WriteLine();
            }
        }

        private static void CheckEnergy()
        {
            if (energy <= 0)
            {
                if (nectar > 30 && recharged is false)
                {
                    energy = nectar - 30;
                    nectar = 30;
                    recharged = true;
                    
                }
                else
                {
                    Console.WriteLine("This is the end! Beesy ran out of energy.");
                    isOver = true;
                }
                
            }
        }

        private static void Up(char[][] matrix)
        {
            matrix[x][y] = '-';
            x--;
            if (x < 0)
            {
                x = matrix.GetLength(0) - 1;
            }

            CheckNewPosition(matrix);
        }

        private static void CheckNewPosition(char[][] matrix)
        {
            if (char.IsDigit(matrix[x][y]))
            {
                nectar += int.Parse(matrix[x][y].ToString());
            }

            if (matrix[x][y] == 'H')
            {
                if (nectar >= 30)
                {
                    Console.WriteLine($"Great job, Beesy! The hive is full. Energy left: {energy}");
                }
                else
                {
                    Console.WriteLine("Beesy did not manage to collect enough nectar.");
                }

                isOver = true;
            }

            matrix[x][y] = 'B';
        }
    }
}


