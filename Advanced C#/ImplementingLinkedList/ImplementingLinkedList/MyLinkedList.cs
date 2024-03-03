using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingLinkedList
{
    public class MyLinkedList
    {
        public int Count { get; set; } = 0;
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddFirst(int number)
        {
            Node node = new Node(number);
            Count++;
            if (Count == 1)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head.Previous = node;
                Head = node;
            }
        }

        public void AddLast(int number)
        {
            Node node = new Node(number);
            Count++;
            if (Count == 1)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }
        }

        public void RemoveFirst()
        {
            if (Count > 1)
            {
                Node node = Head.Next;
                Head.Next = null;
                node.Previous = null;
                Head = node;
                Count--;
            }
            else if (Count == 1)
            {
                Count--;
                Node node = null;
                Head = null;
                Tail = null;
            }

        }
        public void RemoveLast()
        {
            if (Count > 1)
            {
                Node node = Tail.Previous;
                Tail.Previous = null;
                node.Next = null;
                Tail = node;
                Count--;
            }
            else if (Count == 1)
            {
                Count--;
                Node node = null;
                Head = null;
                Tail = null;
            }

        }

        public void ForEach(Action<int> action)
        {
            Node node = Head;

            while (node != null)
            {
                action(node.Value);
                node = node.Next;
            }
        }

        public int[] ToArray()
        {
            int[] array = new int[Count];

            int i = 0;
            Node node = Head;
            while (node != null)
            {
                array[i++] = node.Value;
                node = node.Next;
            }

            return array;
        }
    }
}
