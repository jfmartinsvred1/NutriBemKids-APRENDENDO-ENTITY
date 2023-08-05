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
                

                var mae = new Mae();
                mae.Nome = "Maiardsda";
                mae.Filho = "Maiara";
                mae.QuantidadeFilhos = 5;
                context.Maes.Add(mae);
                context.SaveChanges();
            }
            
        }
  
    }
}