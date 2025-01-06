using System;
using System.Collections;

namespace Lab9
{
    class Books : IEnumerable
    {
        Book[] books;
        public Books() { books = Book.TestBooks(); }

        public IEnumerator GetEnumerator()
        { 
            return books.GetEnumerator();
        }

        public IEnumerable GetByAuthor()
        {
            return new EnumAuthor(books);
        }

        public IEnumerable GetByPrice()
        {
            return new EnumPrice(books);
        }

        public IEnumerable GetReverseEnum() 
        {
            for (int i = books.Length - 1; i >= 0; --i)
                yield return books[i];
        }
    }
}
