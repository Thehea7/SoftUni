using System.Runtime.Intrinsics.X86;
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
            List<string> cityName = new List<string>();

            for (int i = 3; i < info1.Length; i++)
            {
                cityName.Add(info1[i]);
            }
            Threeuple<string, string, string> tuple1 = new Threeuple<string, string, string>(($"{info1[0]} {info1[1]}"), info1[2], string.Join(" ", cityName));
            Threeuple<string, int, bool> tuple2 = new Threeuple<string, int, bool>(info2[0], int.Parse(info2[1]), info2[2] == "drunk");
            Threeuple<string, double, string> tuple3 = new Threeuple<string, double, string>(info3[0], double.Parse(info3[1]), info3[2]);
            
            Console.WriteLine($"{tuple1}\n{tuple2}\n{tuple3}");

            
        }
    }
}