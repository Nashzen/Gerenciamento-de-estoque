using System.ComponentModel.DataAnnotations;
using TCCnew.Models.Base;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TCCnew.Models.DAL;
using System.Data.SqlClient;

namespace TCCnew.Models
{
    public class Funcionario : EntityBase
    {
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Usuário")]
        public string Usuario { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        public string Salario { get; set; }

        [Display(Name = "Está Ativo?")]
        public bool IsAtivo { get; set; }

        [Display(Name = "É gerente?")]
        public bool IsGerente { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]        
        public string Senha { get; set; }

        
        public static bool AutorizarLogin(string login, string senha)
        {
            var teste = false;

            using (var con = new SqlConnection())
            {

                //String matheus
                //con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=D:\TCC\Gerenciamento-de-estoque\TCCnew\App_Data\TCCnew.mdf;Initial Catalog=TCCnew;Integrated Security=True";
                //con.Open();

                //String leo
                con.ConnectionString = @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=C:\Users\leo-s\Documents\GitHub\TCC-V2\Gerenciamento-de-estoque\TCCnew\App_Data\TCCnew.mdf;Initial Catalog=TCCnew;Integrated Security=True";
                con.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = con;
                    comando.CommandText = string.Format(
                        "select count(*) from Funcionario where usuario='{0}' and senha='{1}'", login, senha);
                    teste = ((int)comando.ExecuteScalar() > 0);
                }
            }

            return teste;
        }
    }
    
   
}