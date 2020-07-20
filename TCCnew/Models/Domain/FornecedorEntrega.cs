using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class FornecedorEntrega : EntityBase
    {
        public int FornecedorId { get; set; }

        public virtual Fornecedor Fornecedor { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EntregaId { get; set; }

        public virtual Entrega Entrega { get; set; }
    }
}