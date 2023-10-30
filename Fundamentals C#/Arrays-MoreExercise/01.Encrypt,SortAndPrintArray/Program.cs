namespace _01.Encrypt_SortAndPrintArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int[] output = new int[nLines];
            for (int i = 0; i < nLines; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    char a = input[j];
                    if (a == 'a' || a == 'e' || a == 'i' || a == 'o' || a == 'u' || a == 'A' || a == 'E' || a == 'I' || a == 'O' || a == 'U')
                    {
                        sum += a * input.Length;
                    }
                    else
                    {
                        sum += a / input.Length;
                    }

                }
                output[i] = sum;

            }
            Array.Sort(output);
            foreach (int i in output)
            {
                Console.WriteLine(i);
            }

        }
    }
}