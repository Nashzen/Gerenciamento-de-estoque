using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccSenai.Entities;

namespace TCC_netCore.Entities.Context
{
    public class TccDbContext : DbContext
    {   
        //Contextos das entidades do banco de dados
        public TccDbContext(DbContextOptions<TccDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<StockDelivery> StockDeliveries { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Provider>().ToTable("Provider");
            modelBuilder.Entity<Stock>().ToTable("Stock");
            modelBuilder.Entity<StockDelivery>().ToTable("StockDelivery");
            modelBuilder.Entity<User>().ToTable("User");


        }
    }
}
