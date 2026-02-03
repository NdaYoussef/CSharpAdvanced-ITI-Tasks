using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2P2
{
    internal class Student
    {
        public Dictionary<string,List<int>> Grade {  get; set; }

        //public string Name { get; set; }

        public Student()
        { 
            Grade = new Dictionary<string,List<int>>();
        }
    }
}
