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

        public void Push(params T[] items)
        {
            foreach (var item in items)
            {
                if (Tail == null)
                {
                    Tail = new Node<T>();
                    Tail.Value = item;
                    Tail.IsOdd = true;
                    continue;
                }

                Node<T> current = new Node<T>();
                current.Value = item;
                current.Previous = Tail;
                current.IsOdd = !Tail.IsOdd;
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

            return output;
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            Node<T> currentNode = new Node<T>();
            currentNode = Tail;
            while (currentNode != null)
            {
                yield return currentNode;
                currentNode = currentNode.Previous;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
