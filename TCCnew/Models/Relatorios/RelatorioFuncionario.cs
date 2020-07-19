using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCCnew.Models.DAL;

namespace TCCnew.Models.Relatorios
{
    public class RelatorioFuncionario
    {
        public static List<Funcionario> ListarFuncionarios()
        {
            var lista = new List<Funcionario>();

            using (var db = new GamesContext())
            {
                lista = db.Funcionarios
                    .OrderBy(x => x.Nome)
                    .ToList()
                    .Select(x => new Funcionario()
                    {
                        Nome = x.Nome,
                        Telefone = x.Telefone,
                        Salario = x.Salario,
                        IsAtivo = x.IsAtivo,
                        IsGerente = x.IsGerente
                    }).ToList();
            }

            return lista;
        }
    }
}