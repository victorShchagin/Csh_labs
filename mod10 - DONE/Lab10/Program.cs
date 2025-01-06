using System;
using System.IO;
using System.Xml.Serialization;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book []? books = Books.TestBooks;

            // Сериализация books
            using (StreamWriter sw = new(Path.Combine("..", "..", "..", "books.txt")))
            {
                Type type = books.GetType();
                XmlSerializer xs = new(type);
                xs.Serialize(sw, books);
            }

            // Десериализация books
            using (StreamReader sr = new(Path.Combine("..", "..", "..", "books.txt")))
            {
                Type type = books.GetType();
                XmlSerializer xs = new(type);
                books = xs.Deserialize(sr) as Book[];

                foreach (var book in books)
                { 
                    Console.WriteLine(book);
                }
            }
            Console.WriteLine("Ok");
        }
    }
}
