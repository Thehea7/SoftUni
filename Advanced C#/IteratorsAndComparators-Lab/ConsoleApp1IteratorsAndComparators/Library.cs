using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books { get; set; }

        public Library(params Book[] books)
        {
            this.books = books.OrderBy(x => x, new BookComparator())
                .ToList();
        }

        public IEnumerator<Book> GetEnumerator()
        {
           //return books.GetEnumerator();
           return new LibraryIterator(books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;
            public Book Current { get => books[currentIndex]; }

            public LibraryIterator(IEnumerable<Book> books)
            {
                Reset();
                this.books = books.ToList();
            }


            object IEnumerator.Current => Current;
            public bool MoveNext() => ++currentIndex < books.Count;
            public void Reset() => currentIndex = -1;
            public void Dispose() { }
        }
    }
}
