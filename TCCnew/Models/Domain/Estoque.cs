using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Estoque : EntityBase
    {
        public int QuantidadeTotal { get; set; }

        public int QuantidadeDisponivel { get; set; }

        public int IdJogo { get; set; }

        public virtual ICollection<Jogo> Jogo { get; set; }
    }
}