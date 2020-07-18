using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Funcionario : EntityBase
    {
        public string Nome { get; set; }

        public string Usuario { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public double Salario { get; set; }

        public bool IsAtivo { get; set; }

        public bool IsGerente { get; set; }
    }
}