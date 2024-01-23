namespace _5._SquareWithMaximumSum
{
    internal class Program
    {
        static void Main()
        {
            int[] matrixSize = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] arrayRow = Console.ReadLine()
                    .Split(",")
                    .Select(int.Parse)
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = arrayRow[col];
                }
            }
            int maxSum = 0;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < rows-1; row++)
            {
                for (int col = 0; col < cols-1; col++)
                {
                    int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    } 
                }
            }

            Console.WriteLine($"{matrix[maxRow,maxCol]} {matrix[maxRow, maxCol+1]} ");
            Console.WriteLine($"{matrix[maxRow+1,maxCol]} {matrix[maxRow+1, maxCol+1]} ");
            Console.WriteLine(maxSum);
        }
    }
}