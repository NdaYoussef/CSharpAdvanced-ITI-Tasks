using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Day8
{
    public class RealEstateDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source = NDA ; Initial Catalog = RealEstateITI ; Integrated Security = true; Encrypt = true ; TrustServerCertificate = true;").EnableDetailedErrors(true);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Owner> Owners { get; set; }

        public DbSet<Property> Properties { get; set; }

        public DbSet<SalesOffice> SalesOffices { get; set; }

        public DbSet<PropertyOwner> PropertiesOwner { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SalesOffice>(entity =>
            {
                entity.HasKey(k => k.Number);

                entity
                        .Property(n => n.Location)
                        .HasMaxLength(50)
                        .IsRequired();

                //one office => many Employees
                entity.HasMany(e => e.Employees)
                      .WithOne(s=>s.SalesOffice)
                      .HasForeignKey(f=>f.SalesOfficeId)
                      .OnDelete(DeleteBehavior.Restrict);

                //one office => one manager
                entity.HasOne(e => e.Manager)
                      .WithOne(m=>m.SalesOfficeManager)
                      .HasForeignKey<SalesOffice>(n => n.ManagerId)
                      .OnDelete(DeleteBehavior.Cascade);

                //entity.HasOne(o => o.Manager)
                //      .WithMany()
                //      .HasForeignKey(o => o.ManagerId)
                //      .OnDelete(DeleteBehavior.Restrict);

                //one office => many properties
                entity.HasMany(p => p.Properties)
                      .WithOne(f => f.SalesOffice)
                      .HasForeignKey(p => p.SalesOfficeId);
                
                
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(n=>n.Name)
                .HasMaxLength(50)
                .IsRequired();

                //one office with many employees
                entity.HasOne(f => f.SalesOffice)
                       .WithMany(e=>e.Employees)
                       .HasForeignKey(f => f.SalesOfficeId);


                //one manager per office
                entity.HasOne(s => s.SalesOfficeManager)
                      .WithOne(e=>e.Manager)
                      .HasForeignKey<SalesOffice>(f=>f.ManagerId)
                      .OnDelete(DeleteBehavior.Restrict);

                      
                     
            });
            
            modelBuilder.Entity<PropertyOwner>().HasKey(a=> new {a.OwnerId,a.PropertyId}); //c pk

            modelBuilder.Entity<Property>().Property(a => a.Address)
                                           .HasMaxLength(50);
            modelBuilder.Entity<Property>().Property(a => a.City)
                                           .HasMaxLength(50);
            modelBuilder.Entity<Property>().Property(a => a.State)
                                           .HasMaxLength(50); 
            modelBuilder.Entity<Property>().Property(a => a.ZipCode)
                                           .HasMaxLength(50);

            //one office => 
            modelBuilder.Entity<Property>().HasOne(f => f.SalesOffice)
                                           .WithMany(p => p.Properties)
                                           .HasForeignKey(p => p.SalesOfficeId)
                                           .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PropertyOwner>()
                        .HasOne(po => po.Owner)
                        .WithMany(o => o.PropertyOwners)
                        .HasForeignKey(po => po.OwnerId);

            modelBuilder.Entity<PropertyOwner>()
                .HasOne(po => po.Property)
                .WithMany(p => p.PropertyOwners)
                .HasForeignKey(po => po.PropertyId);





        }
    }
}
