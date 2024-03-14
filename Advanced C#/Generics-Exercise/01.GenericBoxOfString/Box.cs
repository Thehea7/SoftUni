using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.GenericBoxOfString
{
    public class Box<T>
    {
        public T Item { get; set; }

        public Box(T item)
        {
            Item = item;
        }

        public override string ToString()
        {
            return $"{typeof(T)}: {Item}";
        }
    }
}
