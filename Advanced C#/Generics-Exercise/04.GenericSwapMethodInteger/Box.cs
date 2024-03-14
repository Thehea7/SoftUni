using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBoxOfString
{
    internal class Box<T>
    {
        public T Item { get; set; }

        public Box(T item)
        {
            Item = item;
        }

        public static void Swap<T>(List<T> list, int index1, int index2)
        {
            (list[index1] , list[index2]) = (list[index2] ,list[index1]);
        }
        public override string ToString()
        {
            return $"{typeof(T)}: {Item}";
        }
    }
}
