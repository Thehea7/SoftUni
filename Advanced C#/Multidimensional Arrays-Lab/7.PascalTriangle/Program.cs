namespace _7.PascalTriangle
{
    internal class Program
    {
        static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] pascal = new long[rows][];
            pascal[0] = new long[] { 1 };
            
            for (int row = 1; row < rows; row++)
            {
                pascal[row] = new long[row+1];
                pascal[row][0] = 1; pascal[row][pascal[row].Length -1]  = 1;

                for (int col = 1; col < row; col++)
                {
                    pascal[row][col] = pascal[row-1][col -1] + pascal[row -1][col];
                }
            }

            foreach (var i in pascal)
            {
                Console.WriteLine(string.Join(" ", i));
            }
        }
    }
}