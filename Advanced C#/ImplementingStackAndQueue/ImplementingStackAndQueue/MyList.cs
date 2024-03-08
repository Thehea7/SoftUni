using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingStackAndQueue
{
    public class MyList
    {
        private const int initialCapacity = 2;

        private int[] array;

        public int Count { get; private set; }

        public int this[int index]
        {
            get
            {
                if (IndexIsValid(index))
                {

                }

                return array[index];
            }
            set
            {
                if (IndexIsValid(index))
                {
                    array[index] = value;
                }
            }
        }
        public MyList()
        {
            this.array = new int[initialCapacity];
        }

        public MyList(int size)
        {
            array = new int[size];
        }

        private void Resize()
        {
            int[] copy = new int[array.Length * 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = array[i];
            }
            array = copy;
        }

        private bool IndexIsValid(int index)
        {
            if (index >= Count ||
                index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            return true;
        }

        private void Shift(int index)
        {
            for (int i = index; i < Count - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Count--;

            if (array.Length / 4 >= Count)
            {
                Shrink();
            }
        }

        private void Shrink()
        {
            int[] copy = new int[array.Length / 2];
            for (int i = 0; i < Count; i++)
            {
                copy[i] = array[i];
            }

            array = copy;
        }

        public void Add(int element)
        {
            if (Count == array.Length)
            {
                Resize();
            }
            array[Count++] = element;
        }

        public int RemoveAt(int index)
        {
            int element = default;
            if (IndexIsValid(index))
            {
                element = array[index];
                Shift(index);
            }

            return element;
        }

        public void Insert(int index, int element)
        {
            if (Count == array.Length)
            {
                Resize();
            }
            if (index>=0 && index<= Count)
            {
                int[] copy = new int[array.Length];
                for (int i = 0; i < index; i++)
                {
                    copy[i] = array[i];
                }
                copy[index] = element;
                Count++;
                for (int i = index + 1; i < Count; i++)
                {
                    copy[i] = array[i - 1];
                }
                array = copy;
            }
        }

        public bool Contains(int element)
        {
            for (int i = 0; i < Count; i++)
            {
                if (array[i] == element) return true;
            }
            return false;
        }

        public void Swap(int index1, int index2)
        {
            if (IndexIsValid(index1) && IndexIsValid(index2))
            {
                (array[index1], array[index2]) = (array[index2], array[index1]);
            }
        }
        public override string ToString()
        {
            int[] result = new int[Count];
            for (int i = 0; i < Count; i++)
            {
                result[i] = array[i];
            }
            return string.Join(", ", result);
        }
    }
}
