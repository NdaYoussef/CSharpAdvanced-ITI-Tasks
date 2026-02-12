using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class Property
    {
        public int Id {  get; set; }
        public string Address { get; set; }
        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public SalesOffice SalesOffice { get; set; }

        public int SalesOfficeId { get; set; }

    }
}
