using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.Base;

namespace TCCnew.Models
{
    public class Jogo : EntityBase
    {
        public string Nome { get; set; }

        public string CodigoBarras { get; set; }

        public string Genero { get; set; }

        public DateTime DataLancamento { get; set; }

        public double Preco { get; set; }

        public virtual Estoque Estoque { get; set; }

    }
}