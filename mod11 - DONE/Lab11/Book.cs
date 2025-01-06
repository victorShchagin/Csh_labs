using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab11
{
    class Book : IComparable
    {
        public int    Id     { get; set; }
        public double Price  { get; set; }
        public string Title  { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return "id="+Id+" price="+Price+"$  "+Author+" : "+Title;
        }

        public int CompareTo(object obj)
        {
            return (int)Math.Abs(this.Price - ((Book)obj).Price);
        }

        class SortByAuthor : IComparer
        {
            public int Compare(object x, object y)
            {
                int res = 0;
                Book b1 = (Book)x;
                Book b2 = (Book)y;

                res = b1.Author.CompareTo(b2.Author);
                if (res == 0) res = (int)(b1.Price - b2.Price);

                return res;
            }
        }

        public static IComparer ByAuthor()
        { 
            return new SortByAuthor();  
        }
    }
}
