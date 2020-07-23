using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCCnew.Models.DAL
{
    public class GamesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GamesContext>
    {
        protected override void Seed(GamesContext context)
        {
            var funcionarios = new List<Funcionario>
            {
                new Funcionario{Nome="admin", Usuario="admin",Cpf="10789223902",Telefone="44998651760", Salario="10000", IsAtivo = true, IsGerente = false, Senha="admin", }
                
            };
            funcionarios.ForEach(f => context.Funcionarios.Add(f));
            context.SaveChanges();
        }
    }
}