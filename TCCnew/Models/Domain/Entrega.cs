using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Entrega : EntityBase
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Quantidade entregue")]
        public int QuantidadeEntregue { get; set; }

        [Required]
        [Display(Name = "Número da entrega")]
        public int NumeroEntrega { get; set; }

        [Display(Name = "Data de entrega")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataEntrega { get; set; }

        public int IdFornecedor { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

    }
}