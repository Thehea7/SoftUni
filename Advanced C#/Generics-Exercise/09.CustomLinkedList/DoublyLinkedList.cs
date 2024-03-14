using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomDoublyLinkedList
{
    public class DoublyLinkedList<T>
    {
        public int Count { get; set; } = 0;
        public ListNode<T> Head { get; set; }
        public ListNode<T> Tail { get; set; }

        public void AddFirst(T number)
        {
            ListNode<T> node = new ListNode<T>( number);
            Count++;
            if (Count == 1)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.NextNode = Head;
                Head.PreviousNode = node;
                Head = node;
            }
        }

        public void AddLast(T number)
        {
            ListNode<T> node = new ListNode<T>(number);
            Count++;
            if (Count == 1)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.NextNode = node;
                node.PreviousNode = Tail;
                Tail = node;
            }
        }

        public T RemoveFirst()
        {
            
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T result = Head.Value;
             if (Count > 1)
            {
                ListNode<T> node = Head.NextNode;
                Head.NextNode = null;
                node.PreviousNode = null;
                Head = node;
                Count--;

                return result;
            }
            else if (Count == 1)
            {
                Count--;
                ListNode<T> node = null;
                Head = null;
                Tail = null;
                
            }
            return result;
        }
        public T RemoveLast()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("The list is empty");
            }
            T result = Tail.Value;
            if (Count > 1)
            {
                ListNode<T> node = Tail.PreviousNode;
                Tail.PreviousNode = null;
                node.NextNode = null;
                Tail = node;
                Count--;
                return result;
            }
            else if (Count == 1)
            {
                Count--;
                ListNode<T> node = null;
                Head = null;
                Tail = null;
            }

            return result;
        }

        public void ForEach(Action<T> action)
        {
            ListNode<T> node = Head;

            while (node != null)
            {
                action(node.Value);
                node = node.NextNode;
            }
        }

        public T[] ToArray()
        {
            T[] array = new T[Count];

            int i = 0;
            ListNode<T> node = Head;
            while (node != null)
            {
                array[i++] = node.Value;
                node = node.NextNode;
            }

            return array;
        }
    }
}
