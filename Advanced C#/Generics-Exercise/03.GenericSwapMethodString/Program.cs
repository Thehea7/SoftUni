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

            int[] indexes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            int index1 = indexes[0];
            int index2 = indexes[1];
            
            Box<int>.Swap(list, index1, index2);

            foreach (var box in list)
            {
                Console.WriteLine(box);
            }
        }
    }
}