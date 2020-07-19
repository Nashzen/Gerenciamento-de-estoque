using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Entrega : EntityBase
    {

        public int QuantidadeEntregue { get; set; }

        public int NumeroEntrega { get; set; }

        public DateTime DataEntrega { get; set; }

        public int IdFornecedor { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

    }
}