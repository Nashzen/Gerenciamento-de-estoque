using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace TCC_Senai.Models.Maps
{
    public class ProvidersMap : EntityTypeConfiguration<Provider>
    {
        public ProvidersMap()
        {
            ToTable("Provider");

            HasKey(x => x.Id); //Define a PK
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //Define o autoincrement da PK

            Property(x => x.Name).HasMaxLength(100).IsRequired();
            Property(x => x.Phone).HasMaxLength(20).IsRequired();
            Property(x => x.Cnpj).HasMaxLength(20).IsRequired();
            Property(x => x.Email).HasMaxLength(100).IsRequired();
            Property(x => x.CreationDate).IsRequired();
        }
    }
}