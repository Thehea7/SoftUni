using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class ListNode<T> 
    {
        public T Value { get; set; }
        
        public ListNode<T> PreviousNode { get; set; } = null;

        public ListNode<T> NextNode { get; set; } = null;

        public ListNode(T value)  
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
