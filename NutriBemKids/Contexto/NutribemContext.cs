using Microsoft.EntityFrameworkCore;
using NutriBemKids.Negocios;
using System.Reflection.Emit;

namespace NutriBemKids.Contexto
{
    public class NutribemContext:DbContext
    {
        public DbSet<Alunos> Aluno { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Mae> Maes { get; set; }
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
            



            modelBuilder.Entity<Estoque>()
                .HasKey(i => i.Id);
            modelBuilder.Entity<Estoque>()
                .ToTable("EstoqueNutribem");
            modelBuilder.Entity<Estoque>()
                .Property(n => n.Nome)
                .HasColumnName("Nome");
            modelBuilder.Entity<Estoque>()
                .Property(n => n.Quantidade)
                .HasColumnName("Quantidade");
            modelBuilder.Entity<Estoque>()
                .Property(n => n.ValorUnitario)
                .HasColumnName("ValorUnitario");
            modelBuilder.Entity<Estoque>()
                .Property(n => n.Tipo)
                .HasColumnName("Tipo");
            modelBuilder.Entity<Estoque>()
                .Property(d => d.Data)
                .HasColumnName("Data");
        }
    }
}
