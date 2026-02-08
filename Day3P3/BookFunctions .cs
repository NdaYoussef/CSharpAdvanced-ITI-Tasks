using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3P3
{
    internal class BookFunctions
    {
        Book Book { get; set; }
        public static string GetTitle(Book B)
        {
            return B.Title;
        }

        public static string GetAuthors(Book B)
        {
            string[] authors = B.Authors;
           //foreach(var author in authors)
           // {
           //     Console.WriteLine($"Book Author: {author}");
           // }

            return string.Join( ",", authors);
        }

        public static string GetPrice(Book B)
        {
           return B.Price.ToString();
        }

        public static string GetISBNBook(Book book)
        {
            return book.ISBN;
        }
      
        //public override string ToString()
        //{
        //    return   
        //}

    }
}
