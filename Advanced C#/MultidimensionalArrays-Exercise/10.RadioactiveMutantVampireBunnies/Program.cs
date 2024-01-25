using System.Diagnostics;

namespace _10.RadioactiveMutantVampireBunnies
{
    internal class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];

            string[][] matrix = new string[rows][];

            for (int row = 0; row < rows; row++)
            {
                matrix[row] = string.Join(" ", Console.ReadLine().ToCharArray()).Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            Queue<string> commands = new Queue<string>(string.Join(" ", Console.ReadLine().ToCharArray()).Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray());

            GetPlayerCoordinates(matrix, out var playerRow, out var playerCol);

            while (commands.Count > 0)
            {
                int lastRow = playerRow;
                int lastCol = playerCol;

                string command = commands.Dequeue();
                if (command == "U")
                {
                    playerRow--;
                }
                else if (command == "D")
                {
                    playerRow++;
                }
                else if (command == "L")
                {
                    playerCol--;
                }
                else if (command == "R")
                {
                    playerCol++;
                }

                if (IsOut(matrix, playerRow, playerCol))
                {
                    matrix[lastRow][lastCol] = ".";
                    if (RabitExpansionIsDead(matrix))
                    {

                    }
                    PrintMatrix(matrix);
                    Console.WriteLine($"won: {lastRow} {lastCol}");
                    return;
                }
                if (matrix[playerRow][playerCol] == "B")
                {
                    if (RabitExpansionIsDead(matrix))
                    {
                        PrintMatrix(matrix);
                        Console.WriteLine($"dead: {playerRow} {playerCol}");
                    }
                    return;
                }

                matrix[playerRow][playerCol] = "P";
                matrix[lastRow][lastCol] = ".";

                if (RabitExpansionIsDead(matrix))
                {
                    PrintMatrix(matrix);
                    Console.WriteLine($"dead: {playerRow} {playerCol}");
                    return; 
                }

                // PrintMatrix(matrix);
            }
        }

        private static void Boom(string[][] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == "A")
                    {
                        matrix[row][col] = "B";
                    }
                }
            }
        }
        private static bool RabitExpansionIsDead(string[][] matrix)
        {
            bool isDead = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == "B")
                    {
                        for (int i = row - 1; i < row + 2; i++)
                        {
                            for (int j = col - 1; j < col + 2; j++)
                            {
                                if (!IsOut(matrix, i, j) && (i == row || j == col))
                                {
                                    if (matrix[i][j] == ".")
                                    {
                                        matrix[i][j] = "A";
                                    }
                                    else if (matrix[i][j] == "P")
                                    {
                                        isDead = true;
                                        matrix[i][j] = "A";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Boom(matrix);
            return isDead;
        }
        private static bool IsOut(string[][] matrix, int playerRow, int playerCol)
        {
            if (playerRow < 0
                || playerCol < 0
                || playerRow >= matrix.GetLength(0)
                || playerCol >= matrix[playerRow].Length)
            {
                return true;
            }
            return false;
        }

        private static void GetPlayerCoordinates(string[][] matrix, out int playerRow, out int playerCol)
        {
            playerRow = 0;
            playerCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == "P")
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
        }
        private static void PrintMatrix(string[][] matrix)
        {
            foreach (var array in matrix)
            {
                Console.WriteLine(string.Join("", array));
            }

        }
    }
}

