using Alura.Filmes.App.Extensions;
using NutriBemKids.Contexto;
using NutriBemKids.Extensions;
using NutriBemKids.Negocios;
using System.Globalization;

namespace NutriBemKids
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var context = new NutribemContext())
            {
                var aluna = new Alunos();
                aluna.Nome = "maria julieta";
                aluna.Mensalidade = 3230;

                var mae = new Mae();
                mae.Nome = "Maiardsda";
                mae.Filho = aluna;
                context.Aluno.Add(aluna);
                context.Maes.Add(mae);
                context.SaveChanges();
            }
            
        }
  
    }
}