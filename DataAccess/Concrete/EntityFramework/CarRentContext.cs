﻿using Entities.Concrete;
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
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-6B6RG50\SQLEXPRESS;Database=CarRent;User Id=sa;Password=29041998;");
        }
            public DbSet<Car> Cars { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Color> Colors { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<User> Users { get; set; }
            public DbSet<Rental> Rentals { get; set; }
    }
}

