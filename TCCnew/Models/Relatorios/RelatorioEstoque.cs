using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.DAL;

namespace TCCnew.Models.Relatorios
{
    public class RelatorioEstoque
    {
        public static List<Estoque> ListarEstoque()
        {
            var lista = new List<Estoque>();

            using (var db = new GamesContext())
            {
                lista = db.Estoques
                    .OrderBy(x => x.Id)
                    .ToList()
                    .Select(x => new Estoque()
                    {
                        QuantidadeTotal = x.QuantidadeTotal,
                        QuantidadeDisponivel = x.QuantidadeDisponivel,
                        IdJogo = x.IdJogo,
                        Jogo = x.Jogo
                    }).ToList();
            }

            return lista;
        }
    }
}