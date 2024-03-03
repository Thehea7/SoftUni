using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLinkedList
{
    public class Node
    {
        public int Value { get; set; }
        
        public Node Previous { get; set; } = null;

        public Node Next { get; set; } = null;

        public Node(int value)  
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
