using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    public class PropertyOwner
    {
        public Property Property { get; set; }

        public int PropertyId { get; set; }

        public Owner Owner { get; set; }
        public int OwnerId { get; set; }
        public double OwnershipPercentage { get; set; }
    }
}
