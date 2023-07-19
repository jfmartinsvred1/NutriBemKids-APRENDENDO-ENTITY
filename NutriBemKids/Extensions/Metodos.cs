using NutriBemKids.Contexto;
using NutriBemKids.Negocios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutriBemKids.Extensions
{
    public static class Metodos
    {
        public static void AdicionarGasto()
        {
            Gastos gastos= new Gastos();
            Console.WriteLine("================ GASTOS =================");
            Console.Write("Tipo: ");
            gastos.Tipo = Console.ReadLine();
            Console.Write("Valor Do Gasto: R$ ");
            gastos.Valor = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            using (var contexto = new NutribemContext())
            {
                contexto.Gasto.Add(gastos);
                contexto.SaveChanges();

            }

        }
        public static void AdicionarAluno()
        {
            Alunos alunos = new();
            Console.WriteLine("=========== CADASTRO DE ALUNOS ===========");
            Console.Write("Nome: ");
            alunos.Nome = Console.ReadLine();
            Console.Write("Valor Da Mensalidade: R$ ");
            alunos.Mensalidade = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            using (var contexto = new NutribemContext())
            {
                contexto.Aluno.Add(alunos);
                contexto.SaveChanges();

            }

        }
        public static void ListarAlunos()
        {

            using (var context = new NutribemContext())
            {

                foreach (var item in context.Aluno)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
