using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Batch
    {
        public int Id { get; set; }
        [Required]
        public DateTime RoastDate { get; set; } = DateTime.Now;

        [Required]
        public double QuantityKg {  get; set; }

        public CoffeeBean Coffee { get; set; }

        [ForeignKey("Coffee")]
        public int CoffeeBeanId { get; set; }
    }
}
