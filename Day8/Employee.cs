using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public SalesOffice SalesOffice { get; set; }

        public int SalesOfficeId { get; set; }

        public bool IsManager { get; set; } = false;
    }
}
