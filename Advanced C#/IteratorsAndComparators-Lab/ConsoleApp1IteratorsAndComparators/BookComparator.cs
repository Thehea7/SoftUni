using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book? x, Book? y)
        {
            if (x.Title.CompareTo(y.Title) == 0)
            {
                return y.Year.CompareTo(x.Year);
            }
            return x.Title.CompareTo(y.Title);
        }
    }
}
