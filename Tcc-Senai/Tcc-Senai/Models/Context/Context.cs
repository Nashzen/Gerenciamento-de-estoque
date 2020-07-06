using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using TCC_Senai.Models.Maps;

namespace TCC_Senai.Models.Context
{
    public class SysgamesContext : DbContext
    {
        public SysgamesContext() : base("Sysgames")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new EmployeeMap());
            modelBuilder.Configurations.Add(new ProductsMap());
            modelBuilder.Configurations.Add(new ProvidersMap());
            modelBuilder.Configurations.Add(new StocksMap());
            modelBuilder.Configurations.Add(new ShippingDeliveriesMap());
            modelBuilder.Configurations.Add(new UsersMap());
        }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<ShippingDelivery> ShippingDeliveries { get; set; }

        public DbSet<User> Users { get; set; }
    }
}