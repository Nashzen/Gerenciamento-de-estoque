using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Fornecedor : EntityBase
    {
        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

    }
}