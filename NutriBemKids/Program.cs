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
            using(var contexto =new NutribemContext())
            {
                contexto.LogSQLToConsole();
                foreach(var aluno in contexto.Aluno)
                {
                    Console.WriteLine(aluno);
                }
            }
        }
        private static void Adicionar()
        {
            Alunos alunos = new Alunos();
            alunos.Nome = Console.ReadLine();
            alunos.Mensalidade = double.Parse(Console.ReadLine());
            using (var contexto=new NutribemContext())
            {
                contexto.Aluno.Add(alunos);
                contexto.SaveChanges();

            }
        }
    }
}