using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Fornecedor : EntityBase
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        [StringLength(40, ErrorMessage = "Digite o nome do fornecedor", MinimumLength = 3)]
        public string Nome { get; set; }

        [Required]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Telefone inválido", MinimumLength = 10)]
        public string Telefone { get; set; }

        [Required]
        [Display(Name = "E-mail")]
        [StringLength(100, ErrorMessage = "Telefone inválido", MinimumLength = 10)]
        public string Email { get; set; }

    }
}