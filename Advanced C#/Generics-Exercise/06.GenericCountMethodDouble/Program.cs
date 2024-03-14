using System.Linq.Expressions;
using System.Text;

namespace _01.GenericBoxOfString
{
    public class Program
    {
        static void Main()
        {
            int entries = int.Parse(Console.ReadLine());
            List<Box<double>> list = new List<Box<double>>();

            for (int i = 0; i < entries; i++)
            {
                double input = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(input);
                list.Add(box);
            }

            double comparator = double.Parse(Console.ReadLine());
            
            Console.WriteLine(Box<double>.CountGreaterElements(list, comparator));

            
        }
    }
}