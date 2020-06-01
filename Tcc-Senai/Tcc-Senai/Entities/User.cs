using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccSenai.Entities.Base;

namespace TccSenai.Entities
{
    public class User : EntityBase
    {
        public User(string userName, string password, bool isActive, Employee employee)
        {
            UserName = userName;
            Password = password;
            IsActive = isActive;
            Employee = employee;
        }

        public string UserName { get; set; }

        public string Password { get; set; }

        public bool IsActive { get; set; }

        public Employee Employee { get; set; }
    }
}
         