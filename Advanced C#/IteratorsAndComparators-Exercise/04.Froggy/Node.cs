using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class Node<T> : IComparable<Node<T>>
    {
        public T Value { get; set; }

        public Node<T> Previous { get; set; }
        public Node<T> Next { get; set; }
        public bool IsOdd { get; set; }
        public int index { get; set; }

        public int CompareTo(Node<T>? other)
        {
           return index.CompareTo(other.index);
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
