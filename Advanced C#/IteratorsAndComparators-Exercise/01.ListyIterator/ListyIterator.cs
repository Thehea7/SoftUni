using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ListyIterator
{
    public class ListyIterator<T>
    {
        private List<T> list;
        private int currentIndex;

        public ListyIterator(List<T> list)
        {
            this.list = list;
        }

        public bool Move()
        {
            if (HasNext() == false)
            {
                return false;
            }
            currentIndex++;
            return true;
        }

        public bool HasNext()
        {
            return currentIndex + 1 < list.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public void Print()
        {
            if (list.Any() == false)
            {
                throw new ArgumentException();
            }

            Console.WriteLine(list[currentIndex]);
        }


    }
}
