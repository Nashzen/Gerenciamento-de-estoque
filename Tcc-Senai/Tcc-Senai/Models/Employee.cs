using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC_Senai.Models.Base;

namespace TCC_Senai.Models
{
    public class Employee : EntityBase
    {
        public string Name { get; set; }

        public string Cpf { get; set; }

        public string PhoneNumber { get; set; }

        public double Salary { get; set; }

        public bool IsManager { get; set; }
    }
}