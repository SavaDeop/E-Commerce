using ECommerc.Entites.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerc.DataAccess.Context
{
    public class MyContext : DbContext
    {
        public static string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ECommerce;Trusted_Connection=true";
        public MyContext()
        {
        }

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        public DbSet<Products> Product { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Category> Category { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }
        
    }
}
