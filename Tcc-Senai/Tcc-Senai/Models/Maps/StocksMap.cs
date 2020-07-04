using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace TCC_Senai.Models.Maps
{
    public class StocksMap : EntityTypeConfiguration<Stock>
    {
        public StocksMap()
        {
            ToTable("Stock");

            HasKey(x => x.Id); //Define a PK
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //Define o autoincrement da PK

            Property(x => x.TotalAmmount).IsRequired();
            Property(x => x.AvailableAmmount).IsRequired();
            Property(x => x.CreationDate).IsRequired();

            Property(x => x.ProductId).HasColumnName("IdProduto").IsRequired();
            HasRequired(x => x.Product).WithMany().HasForeignKey(x => x.ProductId).WillCascadeOnDelete();


        }
    }
}