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
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}