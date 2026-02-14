using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class AppDbContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source = NDA ; Initial Catalog = Day9ITI ; Integrated Security = true; Encrypt = true ; TrustServerCertificate = true;").UseLazyLoadingProxies();

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Student>(e => {
               e.Property(e=>e.Name).HasMaxLength(50).IsRequired();
               
                e.HasOne(c=>c.Course)
                .WithMany(c => c.Students)
                .HasForeignKey(c=>c.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<Course>(e => { 
            e.Property(n=>n.Name).HasMaxLength(50).IsRequired();

                e.HasMany(c => c.Students)
                .WithOne(c => c.Course)
                .HasForeignKey(c=>c.CourseId)
                .OnDelete(DeleteBehavior.Restrict);
            
            });

            modelBuilder.Entity<StdViewModel>()
                        .HasNoKey()
                        .ToView("vw_StdWithCrs");

        }
    }
}
