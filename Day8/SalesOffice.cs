using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class SalesOffice
    {
        public int Number {  get; set; }

        public string Location { get; set; }

        public List<Employee> Employees { get; set; }

        public Employee Manager { get; set; }

        public int ManagerId { get; set; }

    }
}
