using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.DAL;

namespace TCCnew.Models.Relatorios
{
    public class RelatorioEntrega
    {
        public static List<Entrega> ListarEntrega()
        {
            var lista = new List<Entrega>();

            using (var db = new GamesContext())
            {
                lista = db.Entregas
                    .OrderBy(x => x.DataEntrega)
                    .ToList()
                    .Select(x => new Entrega()
                    {
                        NumeroEntrega = x.NumeroEntrega,
                        DataEntrega = x.DataEntrega,
                        QuantidadeEntregue = x.QuantidadeEntregue,
                        IdFornecedor = x.IdFornecedor

                    }).ToList();
            }

            return lista;
        }
    }
}