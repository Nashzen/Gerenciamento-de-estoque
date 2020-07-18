using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace TCCnew.Models.DAL
{
    public class GamesContext : DbContext
    {
        public GamesContext() : base("GamesContext") { }

        public DbSet<Entrega> Entregas { get; set; }
        public DbSet<EntregaJogo> EntregaJogos { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<FornecedorEntrega> FornecedorEntregas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Jogo> Jogos { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}