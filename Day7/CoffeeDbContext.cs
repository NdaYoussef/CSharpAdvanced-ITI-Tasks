using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class CoffeeDbContext :DbContext
    {

      public DbSet<CoffeeBean> Coffeebeans {  get; set; }
     
      public DbSet<Batch> Batches { get; set; }
  
      public DbSet<Supplier> Suppliers { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source = NDA ; Initial Catalog = Test ; Integrated Security = true; Encrypt = true ; TrustServerCertificate = true;").EnableDetailedErrors(true);

        }


        // Configuration Types
        // 1- EF Conventions
        // 2- Data Annotation
        // 3- Fluent API
        // 4- Configuration Files
    }
}
