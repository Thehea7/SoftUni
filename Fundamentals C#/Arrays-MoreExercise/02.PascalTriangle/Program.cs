namespace _02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] lastArr = new int[1];
            for (int i = 1; i <= n; i++)
            {
                int j = 1;
                int[] currentArr = new int[i];
                currentArr[0] = 1;
                if (i == 1) { currentArr[0] = 1; }
                for ( j = 1; j < currentArr.Length; j++)
                {
                    if (j == currentArr.Length - 1) 
                    {
                        currentArr[j] = 1;
                        break;
                    }
                    currentArr[j] = lastArr[j] + lastArr[j - 1];
                }

              lastArr = new int[i];
                for (j = 0; j < lastArr.Length; j++)
                {
                    lastArr[j] = currentArr[j];
                }
                foreach (var number in currentArr)
                {
                    Console.Write($"{number} ");
                }
                Console.WriteLine();
            }
        }
    }
}

