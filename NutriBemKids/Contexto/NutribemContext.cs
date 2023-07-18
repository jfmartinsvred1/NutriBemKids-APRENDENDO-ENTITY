using Microsoft.EntityFrameworkCore;
using NutriBemKids.Negocios;
using System.Reflection.Emit;

namespace NutriBemKids.Contexto
{
    public class NutribemContext:DbContext
    {
        public DbSet<Alunos> Aluno { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Nutribem;Trusted_connection=true;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alunos>()
                .HasKey(c => c.CodigoID);
        }
    }
}
