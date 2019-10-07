using MercadoTechLibrary.Controller;
using MercadoTechLibrary.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercadoTech
{
    class Program
    {
        public static ControllerMercadoTech controllerMercadoTech = new ControllerMercadoTech();
        static void Main(string[] args)
        {
            MenuPrincipal();
        }


        public static void MenuPrincipal()
        {
            int opcao = 0;
            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("------------- SISTEMA MERCADO TECH --------------\n");
                Console.Write("1 - Funcionários\n2 - Produtos\n3 - Pedidos\n9 - Sair\n\nOpção: ");
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        MenuFuncionarios();
                        break;
                    case 2:
                        MenuProdutos();
                        break;
                    case 3:
                        MenuPedidos();
                        break;


                }
            }
        }

        public static void MenuFuncionarios()
        {
            int opcao = 0;
            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("------------- SISTEMA MERCADO TECH --------------\n");
                Console.Write("1 - Listar Funcionários Cadastrados\n2 - Cadastrar Funcionários\n" +
                    "3 - Excluir Funcionarios\n4 - Desativar Funcionários\n5 - Ativar Funcionários\n9 - Voltar\n\nOpção: ");
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        ListaFuncionarios();
                        RetornaMenu();
                        break;
                    case 2:
                        AdicionaFuncionario();
                        RetornaMenu();
                        break;
                    case 3:
                        ExcluiFuncionario();
                        RetornaMenu();
                        break;
                    case 4:
                        DesativaFuncionario();
                        RetornaMenu();
                        break;
                    case 5:
                        AtivaFuncionario();
                        RetornaMenu();
                        break;

                }
            }
        }

        public static void AdicionaFuncionario()
        {
            Console.WriteLine("\nDigite o nome do funcionario: ");
            string func = Console.ReadLine();
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = func;
            controllerMercadoTech.GetAddFuncionario(funcionario);
        }

        public static void ExcluiFuncionario()
        {
            Console.Write("\nDigite o id do funcionario que deseja excluir: ");
            int funcId = int.Parse(Console.ReadLine());
            Funcionario funcionario = new Funcionario();
            funcionario.Id = funcId;
            controllerMercadoTech.GetDelFuncionario(funcionario);
        }

        public static void RetornaMenu()
        {
            Console.WriteLine("\n*** OPERAÇÃO REALIZADA COM SUCESSO ***");
            Console.WriteLine("\nPressione qualquer tecla para retornar ao menu.");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ListaFuncionarios()
        {
            controllerMercadoTech.GetListaFuncionarios().ForEach(x => Console.WriteLine
            ("Id: {0}\nNome: {1}\nAtivo: {2}\n----------------------------", x.Id, x.Nome, x.Ativo));

        }

        public static void DesativaFuncionario()
        {
            Console.Write("\nDigite o id do funcionario que deseja desativar: ");
            int funcId = int.Parse(Console.ReadLine());
            Funcionario funcionario = new Funcionario();
            funcionario.Id = funcId;
            controllerMercadoTech.GetDesFuncionario(funcionario);

        }

        public static void AtivaFuncionario()
        {
            Console.Write("\nDigite o id do funcionario que deseja ativar: ");
            int funcId = int.Parse(Console.ReadLine());
            Funcionario funcionario = new Funcionario();
            funcionario.Id = funcId;
            controllerMercadoTech.GetAtvFuncionario(funcionario);
        }

        public static void MenuProdutos()
        {
            int opcao = 0;
            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("------------- SISTEMA MERCADO TECH --------------\n");
                Console.Write("1 - Listar Produtos Cadastrados\n2 - Cadastrar Produtos\n" +
                    "3 - Excluir Produtos\n4 - Desativar Produtos\n5 - Ativar Produtos\n6 - Alterar Valor\n9 - Voltar\n\nOpção: ");
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        ListaProdutos();
                        RetornaMenu();
                        break;
                    case 2:
                        AdicionaProdutos();
                        RetornaMenu();
                        break;
                    case 3:
                        ExcluiProduto();
                        RetornaMenu();
                        break;
                    case 4:
                        DesativaProduto();
                        RetornaMenu();
                        break;
                    case 5:
                        AtivaProduto();
                        RetornaMenu();
                        break;
                    case 6:
                        AlteraValorProduto();
                        RetornaMenu();
                        break;

                }
            }
        }

        public static void ListaProdutos()
        {
            controllerMercadoTech.GetListaProdutos().ForEach(x => Console.WriteLine
            ("Id: {0}\nNome: {1}\nValor: {2}\nAtivo: {3}\n----------------------------", x.Id, x.Nome,x.Valor.ToString("C2"), x.Ativo));

        }

        public static void AdicionaProdutos()
        {
            Console.WriteLine("\nDigite o nome do Produto: ");
            string func = Console.ReadLine();
            Console.WriteLine("\nDigite o valor do Produto: ");
            decimal val = decimal.Parse(Console.ReadLine());
            Produto produto = new Produto();
            produto.Nome = func;
            produto.Valor = val;
            controllerMercadoTech.GetAddProduto(produto);
        }

        public static void ExcluiProduto()
        {
            Console.Write("\nDigite o id do produto que deseja excluir: ");
            int prodId = int.Parse(Console.ReadLine());
            Produto produto = new Produto();
            produto.Id = prodId;
            controllerMercadoTech.GetDelProduto(produto);
        }

        public static void DesativaProduto()
        {
            Console.Write("\nDigite o id do produto que deseja desativar: ");
            int prodId = int.Parse(Console.ReadLine());
            Produto produto = new Produto();
            produto.Id = prodId;
            controllerMercadoTech.GetDesProduto(produto);

        }

        public static void AtivaProduto()
        {
            Console.Write("\nDigite o id do produto que deseja ativar: ");
            int prodId = int.Parse(Console.ReadLine());
            Produto produto = new Produto();
            produto.Id = prodId;
            controllerMercadoTech.GetAtvProduto(produto);
        }

        public static void AlteraValorProduto()
        {
            Console.Write("\nDigite o id do produto que deseja alterar o valor: ");
            int prodId = int.Parse(Console.ReadLine());
            Produto produto = new Produto();
            produto.Id = prodId;
            Console.WriteLine("\nDigite o novo valor do Produto: ");
            decimal val = decimal.Parse(Console.ReadLine());
            produto.Valor = val;
            controllerMercadoTech.GetAltValProduto(produto);
        }

        public static void MenuPedidos()
        {
            int opcao = 0;
            while (opcao != 9)
            {
                Console.Clear();
                Console.WriteLine("------------- SISTEMA MERCADO TECH --------------\n");
                Console.Write("1 - Listar Pedidos Cadastrados\n2 - Cadastrar Produtos\n" +
                    "3 - Excluir Produtos\n4 - Desativar Produtos\n5 - Ativar Produtos\n6 - Alterar Valor\n9 - Voltar\n\nOpção: ");
                int.TryParse(Console.ReadLine(), out opcao);
                switch (opcao)
                {
                    case 1:
                        ListaPedidos();
                        RetornaMenu();
                        break;
                    case 2:
                       
                        RetornaMenu();
                        break;
                    case 3:
                       
                        RetornaMenu();
                        break;
                    case 4:
                       
                        RetornaMenu();
                        break;
                    case 5:
                        
                        RetornaMenu();
                        break;
                    case 6:
                   
                        RetornaMenu();
                        break;

                }
            }
        }

        public static void ListaPedidos()
        {
            controllerMercadoTech.GetListaPedidos().ForEach(x => Console.WriteLine
            ("Id: {0}\nProduto: {1}\nQuantidade: {2}\nValor: {3}\nTotal: {4}\nFuncionario: {5}\nAtivo: {6}\n----------------------------", 
            x.Id, x.Produto, x.Quantidade,x.Valor.ToString("C2"),x.Total.ToString("C2"),x.Funcionario, x.Ativo));

        }
    }

    
}
