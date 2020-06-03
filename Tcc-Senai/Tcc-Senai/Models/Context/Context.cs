using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TCC_Senai.Models.Context
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Provider> Providers { get; set; }

        public DbSet<Stock> Stocks { get; set; }

        public DbSet<ShippingDelivery> StockDeliveries { get; set; }

        public DbSet<User> Users { get; set; }
    }
}