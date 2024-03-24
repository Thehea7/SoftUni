using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class Node<T>
    {
        public T Value { get; set; }

        public Node<T> Previous { get; set; }
        public bool IsOdd { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
