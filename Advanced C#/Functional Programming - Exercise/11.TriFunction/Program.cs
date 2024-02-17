using System.Security.Cryptography.X509Certificates;

namespace _11.TriFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Func<string, bool> predicate = IsSolution(number);

            Console.WriteLine(names.FirstOrDefault(x => predicate(x)));
        }

        private static int FindSum(string st)
        {
            int sum =0;
            for (int i = 0; i < st.Length; i++)
            {
                sum += st[i];
            }
            return sum;
        }
        private static Func<string, bool> IsSolution(int number)
        {
            return x => FindSum(x) >= number;
        }
    }
}