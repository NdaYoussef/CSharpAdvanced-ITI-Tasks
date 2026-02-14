using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    [Keyless]
    public class StdViewModel
    {
      //  public int Id { get; set; }
        public string StudentName { get; set; }
        public double StdGPA { get; set; }
        public string CrsName { get; set; }

    }
}
