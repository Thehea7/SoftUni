using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Stack
{
    public class Stack<T> : IEnumerable<Node<T>>
    {
        public Node<T> Tail { get; set; }
        public Node<T> Head { get; set; }

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                if (Tail == null)
                {
                    Node<T> Current = new Node<T>();
                    Current.Value = item;
                    Current.IsOdd = true;
                    Current.index = 0;
                    Head = Current;
                    Tail = Current;
                    continue;
                }

                Node<T> current = new Node<T>
                {
                    Value = item,
                    Previous = Tail,
                    IsOdd = !Tail.IsOdd,
                    index = Tail.index + 1
                };
                Tail.Next = current;
                Tail = current;
            }

        }

        public Node<T> Pop()
        {
            if (Tail == null)
            {
                throw new InvalidOperationException();
            }
            Node<T> output = Tail;
            Tail = Tail.Previous;
            Tail.Next = null;
            return output;
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> currentNode = new Node<T>();
            currentNode = Head;
            while (currentNode != null)
            {
                if (currentNode.IsOdd)
                {
                    yield return currentNode;
                }
                currentNode = currentNode.Next;
            }

            currentNode = Tail;
            while (currentNode != null)
            {
                if (currentNode.IsOdd == false)
                {
                    yield return currentNode;
                }
                
                currentNode = currentNode.Previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
