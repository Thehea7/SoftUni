using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace LabTest1
{
    internal class Program
    {
        static void Main()
        {
            string text = "aaaaaa";

           byte[] testToBytes= Encoding.UTF8.GetBytes(text);
           Console.WriteLine(string.Join(",", testToBytes));

           


        }
    }
}