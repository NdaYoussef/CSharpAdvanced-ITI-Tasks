using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2P2
{
    internal class Browser
    {
        //public string page {  get; set; }
        Stack<string> browsingPages = new Stack<string>();

        public void AddPage(string page)
        {
            browsingPages.Push(page);
            Console.WriteLine("Page added successfully");
        }

        public void RollbackPage()
        {
            if (browsingPages.Count > 0)
            {
                string page = browsingPages.Pop();
                Console.WriteLine($"Page {page} removed sucessfully");
            }
            else
            {
                Console.WriteLine("No pages found!");
            }
        }
    }
}
