using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayCreator
{
    public class ArrayCreator
    {
        public static T[] Create<T>(int lenght, T item)
        {
            T[] array = new T[lenght];
            for (int i = 0; i < lenght; i++)
            {
                array[i] = item;
            }

            return array;
        }
    }
}
