using System.Threading.Channels;

namespace _04.AddVAT
{
    internal class Program
    {
        static void Main()
        {
            Func<double, double> addVatFunc = x => x*1.2;
            
            Console.WriteLine(string.Join("\n", 
                Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(addVatFunc)
                .Select(x => x.ToString("f2"))));
        }
    }
}