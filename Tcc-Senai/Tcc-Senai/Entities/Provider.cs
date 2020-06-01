using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TccSenai.Entities.Base;

namespace TccSenai.Entities
{
    public class Provider : EntityBase
    {
        public Provider(string name, string cnpj, string phone, string email)
        {
            Name = name;
            Cnpj = cnpj;
            Phone = phone;
            Email = email;
        }

        public string Name { get; set; }

        public string Cnpj { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }
    }
}
