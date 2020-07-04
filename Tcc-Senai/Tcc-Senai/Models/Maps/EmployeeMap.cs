using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace TCC_Senai.Models.Maps
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable("Employee");

            HasKey(x => x.Id); //Define a PK
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity); //Define o autoincrement da PK

            Property(x => x.Name).HasMaxLength(100).IsRequired();
            Property(x => x.Cpf).HasMaxLength(11).IsRequired();
            Property(x => x.Salary).IsRequired();
            Property(x => x.PhoneNumber).HasMaxLength(20).IsRequired();
            Property(x => x.IsManager).IsRequired();
            Property(x => x.CreationDate).IsRequired();
        }
    }
}