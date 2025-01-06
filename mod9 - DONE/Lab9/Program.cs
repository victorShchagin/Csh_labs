using System;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Books books = new Books();

            foreach (Book book in books.GetByPrice())       Console.WriteLine(book);
            Console.WriteLine("\n==========\n");
            foreach (Book book in books.GetReverseEnum())   Console.WriteLine(book);
            Console.WriteLine("\n==========\n");
            foreach (Book book in books.GetByAuthor())      Console.WriteLine(book);
            Console.WriteLine("\n==========\n");

            Console.WriteLine("Books:");
            foreach (Book book in books)   Console.WriteLine(book);
        }
    }
}
