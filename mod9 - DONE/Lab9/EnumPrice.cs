using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class EnumPrice : IEnumerator, IEnumerable
    {
        int i = -1;
        Book[] data;

        public EnumPrice(Book[] books)
        {
            data = (Book[])books.Clone();
            Array.Sort(data, Book.ByPrice());
        }
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        public object Current
        {
            get
            {
                return data[i];
            }
        }
        public bool MoveNext()
        {
            i++;
            if (i < data.Length) return true;
            else return false;
        }
        public void Reset()
        {
            i = -1;
        }
    }
}
