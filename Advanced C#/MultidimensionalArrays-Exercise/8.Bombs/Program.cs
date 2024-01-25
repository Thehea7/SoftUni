using System.Diagnostics.CodeAnalysis;

namespace _8.Bombs
{
    internal class Program
    {
        static void Main()
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            int[][] matrix = new int[squareMatrixSize][];

            for (int row = 0; row < squareMatrixSize; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            Queue<int> bombs = new Queue<int>(Console.ReadLine()
                .Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            while (bombs.Count > 0)
            {
                int row = bombs.Dequeue();
                int col = bombs.Dequeue();
                Boom(matrix, row, col);
            }
            int count = 0;
            int sum = 0;
            foreach (var array in matrix)
            {
                foreach (var i in array)
                {
                    if (i > 0)
                    {
                        count++;
                        sum += i;
                    }
                }
            }

            Console.WriteLine($"Alive cells: {count}");
            Console.WriteLine($"Sum: {sum}");
            PrintMatrix(matrix);
        }
        private static void Boom(int[][] matrix, int row, int col)
        {
            int bomb = matrix[row][col];
            if (bomb > 0)
            {
                matrix[row][col] = 0;
                for (int i = row - 1; i < row + 2; i++)
                {
                    for (int j = col - 1; j < col + 2; j++)
                    {
                        if (IsValid(matrix, i, j) && matrix[i][j] > 0)
                        {
                            matrix[i][j] -= bomb;
                        }
                    }
                }
            }
        }
        private static bool IsValid(int[][] matrix, int row, int col)
        {
            if (row < 0
                || col < 0
                || row >= matrix.GetLength(0)
                || col >= matrix[row].Length)
            {
                return false;
            }
            return true;
        }
        private static void PrintMatrix(int[][] matrix)
        {
            foreach (var array in matrix)
            {
                Console.WriteLine(string.Join(" ", array));
            }

        }
    }
}