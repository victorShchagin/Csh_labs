using System;
using System.IO;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            Book []books = Books.TestBooks;

            var averageAll = books.Select(x => x.Price).Average();
            Console.WriteLine("{0:F}", averageAll);
            var averageTech = books.Where(x => x.Genre == "tech").Select(x => x.Price).Average();
            Console.WriteLine("{0:F}", averageTech);
            var averageBy = books.GroupBy(x => x.Genre)
                     .Select(g => new { Genre = g.Key, Avg = g.Average(x => x.Price) });

            foreach (var avg in averageBy)
            {
                Console.WriteLine($"{avg.Genre}: {avg.Avg:F2}");
            }
            Console.WriteLine("Ok");
        }
    }
}
