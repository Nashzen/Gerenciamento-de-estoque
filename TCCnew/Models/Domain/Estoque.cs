using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Estoque : EntityBase
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Quantidade total")]
        public int QuantidadeTotal { get; set; }

        [Required]
        [Display(Name = "Quantidade disponível em estoque")]
        public int QuantidadeDisponivel { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdJogo { get; set; }

        public virtual ICollection<Jogo> Jogo { get; set; }
    }
}