using System.Linq.Expressions;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            List<Box<string>> list = new List<Box<string>>();

            for (int i = 0; i < entries; i++)
            {
                string input = Console.ReadLine();
                Box<string> box = new Box<string>(input);
                list.Add(box);
            }

            string comparator = Console.ReadLine();
            
            Console.WriteLine(Box<string>.CountGreaterElements(list, comparator));

            
        }
    }
}