using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class EntregaJogo : EntityBase
    {
        public int FornecedorEntregaId { get; set; }

        public FornecedorEntrega FornecedorEntrega { get; set; }

        public int IdJogo { get; set; }

        public virtual ICollection<Jogo> Jogo { get; set; }
    }
}