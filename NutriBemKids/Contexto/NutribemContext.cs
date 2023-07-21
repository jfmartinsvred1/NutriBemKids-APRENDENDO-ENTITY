using Microsoft.EntityFrameworkCore;
using NutriBemKids.Negocios;
using System.Reflection.Emit;

namespace NutriBemKids.Contexto
{
    public class NutribemContext:DbContext
    {
        public DbSet<Alunos> Aluno { get; set; }
        public DbSet<Gastos> Gasto { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Nutribem;Trusted_connection=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alunos>()               
                .HasKey(c => c.CodigoID);
            modelBuilder.Entity<Alunos>()
                .ToTable("AssinaturaNutribem");
            modelBuilder.Entity<Alunos>()
                .Property(n => n.Nome)
                .HasColumnName("Nome");
            modelBuilder.Entity<Alunos>()
                .Property(n => n.Mensalidade)
                .HasColumnName("Preco");
        }
    }
}
