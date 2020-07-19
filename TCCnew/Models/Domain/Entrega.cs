using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Entrega : EntityBase
    {

        public int QuantidadeEntregue { get; set; }

        public int NumeroEntrega { get; set; }

        [Display(Name = "Data de entrega")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        public DateTime DataEntrega { get; set; }

        public int IdFornecedor { get; set; }

        public virtual ICollection<Fornecedor> Fornecedor { get; set; }

    }
}