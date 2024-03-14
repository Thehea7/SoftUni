using System.Linq.Expressions;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());

            for (int i = 0; i < entries; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
                Console.WriteLine(box);
            }
        }
    }
}