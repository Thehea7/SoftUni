using System.Linq.Expressions;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            List<Box<int>> list = new List<Box<int>>();

            for (int i = 0; i < entries; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(input);
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