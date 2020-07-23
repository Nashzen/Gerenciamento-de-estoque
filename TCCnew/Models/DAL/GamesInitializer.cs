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
                new Funcionario{Nome="admin", Usuario="admin",Cpf="11111111111",Telefone="1111111111", Salario=10}
                
            };
            funcionarios.ForEach(f => context.Funcionarios.Add(f));
            context.SaveChanges();
        }
    }
}