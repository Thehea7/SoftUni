namespace _5.SnakeMoves
{
    internal class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = size[0];
            int cols = size[1];
            char[,] matrix = new char[rows, cols];
            string snake = Console.ReadLine();
            int count = 0;

            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        matrix[row, col] = snake[count % snake.Length];
                        count++;
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snake[count % snake.Length];
                        count++;
                    }
                }
            }

            PrintMatrix(matrix);
        }
        private static void PrintMatrix(char[,] matrix)
        {
            for (int rol = 0; rol < matrix.GetLength(0); rol++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[rol, col]}");
                }

                Console.WriteLine();
            }
        }
    }
}