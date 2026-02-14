using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double GPA { get; set; }
        public virtual Course Course { get; set; }
        public int CourseId { get; set; }   
    }
}
