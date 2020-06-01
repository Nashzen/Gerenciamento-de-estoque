using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccSenai.Entities.Base;

namespace TccSenai.Entities
{
    public class Employee : EntityBase
    {
        public Employee(string name, string cpf, string phoneNumber, double salary, bool isManager)
        {
            Name = name;
            Cpf = cpf;
            PhoneNumber = phoneNumber;
            Salary = salary;
            IsManager = isManager;
        }

        public string Name { get; set; }

        public string Cpf { get; set; }

        public string PhoneNumber { get; set; }

        public double Salary { get; set; }

        public bool IsManager { get; set; }
    }
}
