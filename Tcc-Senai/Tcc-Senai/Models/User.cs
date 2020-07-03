using System.ComponentModel.DataAnnotations;
using TCC_Senai.Models.Base;

namespace TCC_Senai.Models
{
    public class User : EntityBase
    {
        [Display(Name = "Usuário")]
        [Required(ErrorMessage = "Informe um usuário válido")]
        public string UserName { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Senha incorreta")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "ativo")]
        public bool IsActive { get; set; }

        [Display(Name = "empregado")]
        public Employee Employee { get; set; }
    }
}