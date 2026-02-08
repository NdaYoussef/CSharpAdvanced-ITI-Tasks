using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day3P3.Program;

namespace Day3P3
{
    internal class LibraryEngine
    {
        //Func<Book, string> GetTitleDelgate = (book) => book.Title;

        public static void ProcessBooksBCL(List<Book> bList, Func<Book, object> fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }

        public static void ProcessBooks(List<Book> bList, GetPriceDelgaet fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    }
}
