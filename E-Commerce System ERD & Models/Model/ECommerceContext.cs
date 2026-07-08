using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce_System_ERD___Models.Model
{
    public class ECommerceContext : DbContext

    {
        public DbSet<Order> orders { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<Review> reviews { get; set; }
        public DbSet<User > users { get; set; }
        public DbSet<OrderItem> orderItems { get; set; }
        public DbSet<Product> products { get; set; }

        






        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Louai;Database=ECommerceDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }


    }
}
