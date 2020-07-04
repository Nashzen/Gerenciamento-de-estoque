using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace TCC_Senai.Models.Maps
{
    public class ShippingDeliveriesMap : EntityTypeConfiguration<ShippingDelivery>
    {
        public ShippingDeliveriesMap()
        {
            ToTable("ShippingDelivery");

            HasKey(x => x.Id); //Define a PK
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //Define o autoincrement da PK

            Property(x => x.EstimateDate).IsRequired();
            Property(x => x.DeliveryDate).IsRequired();
            Property(x => x.QuantityDelivered).IsRequired();
            Property(x => x.DeliveryValue).IsRequired();
            Property(x => x.CreationDate).IsRequired();

            Property(x => x.IdProvider).HasColumnName("IdProvider").IsRequired();
            HasRequired(x => x.Provider).WithMany().HasForeignKey(x => x.IdProvider).WillCascadeOnDelete();


        }
    }
}