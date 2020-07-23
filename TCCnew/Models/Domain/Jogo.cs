using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Jogo : EntityBase
    {
        [Required]
        [Display(Name = "Nome")]
        [StringLength(100, ErrorMessage = "Digite um nome", MinimumLength = 5)]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Código de barras")]
        [StringLength(50, ErrorMessage = "Código de barras precisa conter no mínimo 5 dígitos", MinimumLength = 5)]
        public string CodigoBarras { get; set; }

        [Required]
        [Display(Name = "Gênero")]
        [StringLength(30, ErrorMessage = "Diga o gênero do jogo", MinimumLength = 5)]
        public string Genero { get; set; }

        [Display(Name = "Data de Lançamento")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataLancamento { get; set; }

        [Required]        
        [Display(Name = "Preço")]
        public string Preco { get; set; }


    }
}