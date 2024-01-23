namespace _1.SumMatrixElements
{
    internal class Program
    {
        static void Main()
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                int[] arrayRow = Console.ReadLine().Split(", ", StringSplitOptions.TrimEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)    
                {
                    matrix[i, col] = arrayRow[col];
                }
            }

            int sum = 0;
            foreach (var i in matrix)
            {
                sum += i;
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);
        }
    }
}