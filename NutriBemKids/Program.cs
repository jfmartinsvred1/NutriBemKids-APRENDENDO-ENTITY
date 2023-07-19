using Alura.Filmes.App.Extensions;
using NutriBemKids.Contexto;
using NutriBemKids.Negocios;

namespace NutriBemKids
{
    class Program
    {
        static void Main(string[] args)
        {

            Adicionar();
        }
        private static void Adicionar()
        {
            Alunos alunos = new();
            Console.Write("Nome: ");
            alunos.Nome = Console.ReadLine();
            Console.Write("Valor Da Mensalidade: ");
            alunos.Mensalidade = decimal.Parse(Console.ReadLine());
            using (var contexto=new NutribemContext())
            {
                contexto.Aluno.Add(alunos);
                contexto.SaveChanges();

            }
        }
    }
}