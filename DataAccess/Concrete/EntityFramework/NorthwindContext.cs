﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        // Bu metot hangi veritabanı ileilişkili olduğumuzu belirttiğimiz metot
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // ConnectionString yazacağımız yer.
            optionsBuilder.UseSqlServer(@"Server = TITO; Database=Northwind;Trusted_Connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}