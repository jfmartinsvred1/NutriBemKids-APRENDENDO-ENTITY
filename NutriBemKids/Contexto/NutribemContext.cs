using Microsoft.EntityFrameworkCore;
using NutriBemKids.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriBemKids.Contexto
{
    public class NutribemContext:DbContext
    {
        public DbSet<Alunos> Aluno { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Nutribem;Trusted_connection=true;");
        }
    }
}
