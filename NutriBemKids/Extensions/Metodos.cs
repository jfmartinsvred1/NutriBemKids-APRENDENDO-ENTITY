using Microsoft.EntityFrameworkCore.Query.Internal;
using NutriBemKids.Contexto;
using NutriBemKids.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                while (opcao != '9')
                {
                    Console.Clear();
                    Console.WriteLine("===============================");
                    Console.WriteLine("===       Atendimento       ===");
                    Console.WriteLine("===1 - Cadastrar Aluno      ===");
                    Console.WriteLine("===2 - Listar Alunos        ===");
                    Console.WriteLine("===3 - Remover Aluno        ===");
                    Console.WriteLine("===4 - Cadastrar No Estoque ===");
                    Console.WriteLine("===5 - Pesquisar Aluno      ===");
                    Console.WriteLine("===6 - Listar Estoque       ===");
                    Console.WriteLine("===7 - Atualizar Estoque    ===");
                    Console.WriteLine("===8 - Faturamento          ===");
                    Console.WriteLine("===9 - Sair do Sistema      ===");
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
                            RemoverAluno();
                            break;
                        case '4':
                            CadastrarNovoProdutoEstoque();
                            break;
                        case '5':
                            PesquisarAluno();
                            break;
                        case '6':
                            ListarEstoque();
                            break;
                        case '7':
                            AtualizarEstoque();
                            break;
                        case '8':
                            FaturamentoTotal();
                            break;
                        case '9':

                            break;
                        default:
                            Console.WriteLine("Opção não implementada.");
                            break;
                    }
                }
            }


            catch (Exception excecao)
            {
                Console.WriteLine($"{excecao.Message}");
            }

        }
        public static void AtualizarEstoque()
        {
            Console.Clear();
            Console.Write("Nome Do Produto: ");
            var nome = Console.ReadLine();
            using (var e = new NutribemContext())
            {
                IList<Estoque> es = e.Estoque.ToList();
                foreach (var item in es)
                {

                    if (item.Nome == nome)
                    {
                        Console.Write("Deseja Adicionar Ou Remover(a/r): ");
                        char resp=char.Parse(Console.ReadLine());
                        if (resp == 'r')
                        {
                            Console.Write($"Deseja Remover Quantos {item.Nome} do estoque: ");
                            item.Quantidade-=int.Parse(Console.ReadLine());
                            e.Estoque.Update(item);
                            e.SaveChanges();
                        }
                        if(resp == 'a')
                        {
                            double valorAntigoTotal=item.Quantidade*item.ValorUnitario;
                            Console.Write($"Deseja Adicionar Quantos {item.Nome} Ao Estoque: ");
                            item.Quantidade+=int.Parse(Console.ReadLine());
                            Console.Write("Valor Total Pago: ");
                            double valorNovo=double.Parse(Console.ReadLine());
                            item.ValorUnitario=(valorAntigoTotal+valorNovo)/item.Quantidade;
                            e.Estoque.Update(item);
                            e.SaveChanges();
                        }
                    }
                }
            }
        }
        public static void CadastrarNovoProdutoEstoque()
        {
            Console.Clear();
            Estoque estoque= new Estoque();
           
            using (var contexto = new NutribemContext())
            {
                Console.WriteLine("================ Estoque =================");
                Console.Write("Nome: ");
                estoque.Nome = Console.ReadLine();
                Console.Write("Tipo: ");
                estoque.Tipo = Console.ReadLine();
                Console.Write("Valor Do Produto: R$ ");
                double valor = double.Parse(Console.ReadLine().Replace(',', '.'), CultureInfo.InvariantCulture);
                Console.Write($"Informe A Quantidade De {estoque.Nome}: ");
                int qntd = int.Parse(Console.ReadLine());
                estoque.ValorUnitario = ((valor / qntd));
                estoque.Quantidade = qntd;

                contexto.Estoque.Add(estoque);
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
            Console.Clear();

            using (var context = new NutribemContext())
            {
                
                foreach (var alunos in context.Aluno)
                {
                    Console.WriteLine(alunos);
                    
                }
                Console.ReadLine();
            }
        }
        public static void ListarEstoque()
        {
            Console.Clear();
            using (var context = new NutribemContext())
            {

                foreach (var estoque in context.Estoque)
                {
                    Console.WriteLine(estoque);

                }
                Console.ReadLine();
            }
        }
        public static void FaturamentoTotal()
        {

            decimal soma = 0;
            Console.Clear();
            using(var context = new NutribemContext())
            {
                foreach(var alunos in context.Aluno)
                {
                    soma += alunos.Mensalidade;

                }
                


            }
            Console.WriteLine($"Faturamento Total De: R$ {soma.ToString("f2", CultureInfo.InvariantCulture)}");
            Console.ReadLine();
        }
        public static void RemoverAluno()
        {
            Console.Clear();
            Console.Write("Nome Do Aluno: ");
            var nome=Console.ReadLine();

            using(var a =new NutribemContext())
            {
                IList<Alunos> aluno=a.Aluno.ToList();
                foreach(var item in aluno)
                {
                    if(item.Nome==nome)
                    
                    a.Aluno.Remove(item);
                }
                a.SaveChanges();
            }
        }
        public static void PesquisarAluno()
        {
            Console.Clear();
            Console.Write("Nome Do Aluno: ");
            var nome= Console.ReadLine();
            using(var a = new NutribemContext())
            {
                IList<Alunos> aluno =a.Aluno.ToList();
                foreach(var item in aluno)
                {

                    if (item.Nome == nome)
                    {
                        Console.WriteLine(item); ;
                    }
                }

            }
            Console.ReadLine();
        }
    }
}
