using System.ComponentModel.DataAnnotations;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Funcionario : EntityBase
    {
        [Required]
        [StringLength(100, ErrorMessage = "Digite um nome")]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Usuário")]
        [StringLength(30, ErrorMessage = "O usuário precisa conter no mínimo 5 dígitos", MinimumLength = 5)]
        public string Usuario { get; set; }

        [Required]
        [Display(Name = "CPF")]
        [StringLength(11, ErrorMessage = "CPF contém apenas 11 dígitos")]
        public string Cpf { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "Telefone inválido" , MinimumLength = 10)]
        public string Telefone { get; set; }

        [Required]
        [Range(0, 30000.00)]
        [Display(Name = "Salário")]
        public double Salario { get; set; }

        [Display(Name = "Funcionário ativo?")]
        public bool IsAtivo { get; set; }

        [Display(Name = "É gerente?")]
        public bool IsGerente { get; set; }
    }
    
   
}