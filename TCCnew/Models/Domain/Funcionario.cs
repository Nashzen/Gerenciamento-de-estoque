using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;
using TCCnew.Models.DAL;

namespace TCCnew.Models
{
    public class Funcionario : EntityBase
    {
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Usuário")]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Cpf")]
        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public double Salario { get; set; }

        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }

        public bool IsAtivo { get; set; }

        public bool IsGerente { get; set; }
    }
    
   
}