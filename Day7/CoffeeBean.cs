using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class CoffeeBean
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        public string OriginCountry { get; set; }

        [Precision(5,2)]
        public decimal PricePerKeg { get; set; }

        [Range(1,5)]
        public int RoastLevel { get; set; }

        public Supplier Supplier { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierId 
            { get; set; }
    }
}
