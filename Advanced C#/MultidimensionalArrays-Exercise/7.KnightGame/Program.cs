namespace _7.KnightGame
{
    internal class Program
    {
        static void Main()
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());

            char[][] matrix = new char[squareMatrixSize][];

            for (int row = 0; row < squareMatrixSize; row++)
            {
                matrix[row] = Console.ReadLine().ToCharArray();
            }
            int removedKnights = 0;

            while (true)
            {
                int maxCount = 0;
                int maxRow = 0;
                int maxCol = 0;

                for (int row = 0; row < squareMatrixSize; row++)
                {
                    for (int col = 0; col < squareMatrixSize; col++)
                    {
                        char ch = matrix[row][col];
                        if (ch == 'K')
                        {
                            if (Attacks(matrix, row, col) > maxCount)
                            {
                                maxCount = Attacks(matrix, row, col);
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }

                if (maxCount > 0)
                {
                    matrix[maxRow][maxCol] = '0';
                    removedKnights++;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(removedKnights);
        }
        public static int Attacks(char[][] matrix, int row, int col)
        {
            int count = 0;
            if (IsValid(matrix, row - 1, col - 2))
            {
                char ch = matrix[row - 1][col - 2];
                if (ch == 'K') count++;
            }
            if (IsValid(matrix, row - 2, col - 1))
            {
                char ch = matrix[row - 2][col - 1];
                if (ch == 'K') count++;
            }
            if (IsValid(matrix, row - 2, col + 1))
            {
                char ch = matrix[row - 2][col + 1];
                if (ch == 'K') count++;
            }
            if (IsValid(matrix, row - 1, col + 2))
            {
                char ch = matrix[row - 1][col + 2];
                if (ch == 'K') count++;
            }
            if (IsValid(matrix, row + 1, col + 2))
            {
                char ch = matrix[row + 1][col + 2];
                if (ch == 'K') count++;
            }
            if (IsValid(matrix, row + 2, col + 1))
            {
                char ch = matrix[row + 2][col + 1];
                if (ch == 'K') count++;
            }
            if (IsValid(matrix, row + 2, col - 1))
            {
                char ch = matrix[row + 2][col - 1];
                if (ch == 'K') count++;
            }
            if (IsValid(matrix, row + 1, col - 2))
            {
                char ch = matrix[row + 1][col - 2];
                if (ch == 'K') count++;
            }

            return count;
        }
        public static bool IsValid(char[][] matrix, int row, int col)
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
    }
}