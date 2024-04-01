using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main()
        {
            RandomList list = new() { "a", "b", "c", "d", "e" };
            while (list.Count > 0)
            {
                Console.WriteLine(list.RandomString());
            }

        }
    }
}
