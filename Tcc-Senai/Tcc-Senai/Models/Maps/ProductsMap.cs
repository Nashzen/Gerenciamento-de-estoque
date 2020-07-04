using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace TCC_Senai.Models.Maps
{
    public class ProductsMap : EntityTypeConfiguration<Product>
    {
        public ProductsMap()
        {
            ToTable("Product");

            HasKey(x => x.Id); //Define a PK
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //Define o autoincrement da PK

            Property(x => x.Name).HasMaxLength(100).IsRequired();
            Property(x => x.ReleaseYear).IsRequired();
            Property(x => x.Genre).IsRequired();
            Property(x => x.Price).IsRequired();
            Property(x => x.ReleaseYear).IsRequired();
            Property(x => x.CreationDate).IsRequired();
        }
    }
}