using System.Security.Cryptography;

namespace _07.Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] info1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] info2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] info3 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, string> tuple1 = new Tuple<string, string>(($"{info1[0]} {info1[1]}"), info1[2]);
            Tuple<string, int> tuple2 = new Tuple<string, int>(info2[0], int.Parse(info2[1]));
            Tuple<int, double> tuple3 = new Tuple<int, double>(int.Parse(info3[0]), double.Parse(info3[1]));

            Console.WriteLine($"{tuple1}\n{tuple2}\n{tuple3}");
        }
    }
}