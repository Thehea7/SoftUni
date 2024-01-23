namespace BonusProblemFromDakov
{
    internal class Program
    {
        static void Main()
        {
            //same as problem 5, but we have to let the size of the max square to be inserted from the console;

            int[] matrixSize = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();

            int rows = matrixSize[0];
            int cols = matrixSize[1];

            int[] squareSize = Console.ReadLine()
                .Split(",")
                .Select(int.Parse)
                .ToArray();
            int squareRows = squareSize[0];
            int squareCols = squareSize[1];

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



            for (int row = 0; row < rows - squareRows +1; row++)
            {
                for (int col = 0; col < cols - squareCols +1; col++)
                {
                    int sum = 0;

                    for (int i = row; i < row +squareRows; i++)
                    {
                        for (int j = col; j < col + squareCols; j++)
                        {
                            sum += matrix[i, j];
                        }
                    }

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            for (int i = maxRow; i < maxRow+squareRows; i++)
            {
                for (int j = maxCol; j < maxCol + squareCols; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine(maxSum);
        }
    }
}