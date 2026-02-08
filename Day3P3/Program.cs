using System;
using System.Security.Cryptography.X509Certificates;

namespace Day3P3
{
    internal class Program
    {
        public delegate string GetPriceDelgaet(Book book); //user defined


        static void Main(string[] args)
        {
            string[] authors = { "autho1", "author2" };
            Book book = new Book("ISBN1","book1",authors, "20/10", 50.2m );

            GetPriceDelgaet GetPriceDelegate = BookFunctions.GetPrice;
            Func<Book, string> getTitleDelgate = BookFunctions.GetTitle;

            Func<Book, string> GetBookAuthorsDelagate = BookFunctions.GetAuthors;

            Func<Book,object> GetTitleDelgate = (book) => book.Title; 
          //  Func<Book,string> GetBookDelgate = (book) => book.Title; 

            Console.WriteLine($"{GetPriceDelegate.Invoke(book)}");
            Console.WriteLine($"Book title by delegate: {getTitleDelgate.Invoke(book)}");

            Console.WriteLine($"All authors of book: {GetBookAuthorsDelagate.Invoke(book)}");

            Console.WriteLine($"Book title: {GetTitleDelgate.Invoke(book)}");


            List<Book> books = new List<Book>()
            {
                new Book ("ISBN1","title1", authors, "20/10", 50.2m ),
                new Book ("ISBN2","title2", authors, "21/10", 51.2m ),

            };

            Console.WriteLine("=============================");
            LibraryEngine.ProcessBooks(books, GetPriceDelegate);
            LibraryEngine.ProcessBooks(books, getTitleDelgate);


            LibraryEngine.ProcessBooks(books, x=>x.PublicationDate);
            //   Console.WriteLine();

        }
    }
}
