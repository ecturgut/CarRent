using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class CarRentContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6B6RG50\SQLEXPRESS;Database=CarRent;Trusted_Connection=true");
        }
            public DbSet<Cars> Cars { get; set; }
            public DbSet<Brands> Brands { get; set; }
            public DbSet<Colors> Colors { get; set; }
    }
}

