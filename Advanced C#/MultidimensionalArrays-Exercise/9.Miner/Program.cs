namespace _9.Miner
{
    internal class Program
    {
        static void Main()
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());
            Queue<string> commands = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            string[][] matrix = new string[squareMatrixSize][];

            for (int row = 0; row < squareMatrixSize; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            var startRow = FindStartAndCoalCount(matrix, out var startCol, out var coalCount);

            while (commands.Count > 0 && coalCount > 0)
            {
                if (ExcecuteCommands(commands, matrix, ref startRow, ref startCol, ref coalCount)) return;
            }

            PrintOutput(coalCount, startRow, startCol);
        }

        private static bool ExcecuteCommands(Queue<string> commands, string[][] matrix, ref int startRow, ref int startCol,
            ref int coalCount)
        {
            string command = commands.Dequeue();
            string currentPosition = matrix[startRow][startCol];
            if (command == "up" && startRow - 1 >= 0)
            {
                currentPosition = matrix[startRow - 1][startCol];
                startRow--;
                if (currentPosition == "c")
                {
                    matrix[startRow][startCol] = "*";
                    coalCount--;
                }
            }
            else if (command == "down" && startRow + 1 < matrix.GetLength(0))
            {
                currentPosition = matrix[startRow + 1][startCol];
                startRow++;
                if (currentPosition == "c")
                {
                    coalCount--;
                    matrix[startRow][startCol] = "*";
                }
            }
            else if (command == "left" && startCol - 1 >= 0)
            {
                currentPosition = matrix[startRow][startCol -1];
                startCol--;
                if (currentPosition == "c")
                {
                    coalCount--;
                    matrix[startRow][startCol] = "*";
                }
            }
            else if (command == "right" && startCol + 1 < matrix[startRow].Length)
            {
                currentPosition = matrix[startRow][startCol+1];
                startCol++;
                if (currentPosition == "c")
                {
                    coalCount--;
                    matrix[startRow][startCol] = "*";
                }
            }
            if (currentPosition == "e")
            {
                Console.WriteLine($"Game over! ({startRow}, {startCol})");
                return true;
            }

            return false;
        }
        private static int FindStartAndCoalCount(string[][] matrix, out int startCol, out int coalCount)
        {
            int startRow = 0;
            startCol = 0;
            coalCount = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == "s")
                    {
                        startRow = row;
                        startCol = col;
                    }
                    else if (matrix[row][col] == "c")
                    {
                        coalCount++;
                    }
                }
            }

            return startRow;
        }
        private static void PrintOutput(int coalCount, int startRow, int startCol)
        {
            if (coalCount == 0)
            {
                Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
            }
            else
            {
                Console.WriteLine($"{coalCount} coals left. ({startRow}, {startCol})");
            }
        }
    }
}