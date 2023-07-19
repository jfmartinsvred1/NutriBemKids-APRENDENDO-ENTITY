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
        public static void Sistemas()
        {
            try
            {
                char opcao = '0';
                while (opcao != '8')
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("===       Atendimento       ===");
                    Console.WriteLine("===1 - Cadastrar Aluno      ===");
                    Console.WriteLine("===2 - Listar Alunos        ===");
                    Console.WriteLine("===3 - Remover Aluno        ===");
                    Console.WriteLine("===4 - Cadastrar Gasto      ===");
                    Console.WriteLine("===5 - Pesquisar Aluno      ===");
                    Console.WriteLine("===6 - Pesquisar Gastos     ===");
                    Console.WriteLine("===7 - Remover Gastos       ===");
                    Console.WriteLine("===8 - Sair do Sistema      ===");
                    Console.WriteLine("===============================");
                    Console.WriteLine("\n\n");
                    Console.Write("Digite a opção desejada: ");
                    try
                    {
                        opcao = Console.ReadLine()[0];
                    }
                    catch (Exception excecao)
                    {
                        throw new Exception(excecao.Message);
                    }

                    switch (opcao)
                    {
                        case '1':
                            AdicionarAluno();
                            break;
                        case '2':
                            ListarAlunos();
                            break;
                        case '3':
                            //Metodos.RemoverAluno();
                            break;
                        case '4':
                            AdicionarGasto();
                            break;
                        case '5':
                            //Metodos.ListarAluno();
                            break;
                        case '6':
                            Metodos.ListarGastos();
                            break;
                        case '7':
                            //Metodos.RemoverGastos();
                            break;
                        case '8':
                            break;
                        default:
                            Console.WriteLine("Opcao não implementada.");
                            break;
                    }
                }
            }


            catch (Exception excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }

        }
        public static void AdicionarGasto()
        {
            Console.Clear();
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
            Console.Clear();
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
                
                foreach (var alunos in context.Aluno)
                {
                    Console.WriteLine(alunos);
                    
                }
                Console.ReadLine();
            }
        }
        public static void ListarGastos()
        {
            Console.Clear();
            using (var context = new NutribemContext())
            {

                foreach (var gastos in context.Gasto)
                {
                    Console.WriteLine(gastos);

                }
                Console.ReadLine();
            }
        }
    }
}
