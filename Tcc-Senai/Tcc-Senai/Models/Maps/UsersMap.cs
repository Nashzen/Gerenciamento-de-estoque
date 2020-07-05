using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace TCC_Senai.Models.Maps
{
    public class UsersMap : EntityTypeConfiguration<User>
    {
        public UsersMap()
        {
            ToTable("User");

            HasKey(x => x.Id); //Define a PK
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //Define o autoincrement da PK

            Property(x => x.UserName).HasMaxLength(30).IsRequired();
            Property(x => x.Password).HasMaxLength(15).IsRequired();            
            Property(x => x.CreationDate).IsRequired();

            Property(x => x.IdEmployee).HasColumnName("IdEmployee").IsRequired();
            HasRequired(x => x.Employee).WithMany().HasForeignKey(x => x.IdEmployee).WillCascadeOnDelete();


        }
    }
}