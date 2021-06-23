using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            Console.WriteLine("Numero de produtos para cadastrar: ");
            int numeroProdutos = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeroProdutos; i++)
            {
                Console.WriteLine($"Dados do produto #{i+1}");
                Console.WriteLine("Produto comum/Usado/Importado? (c/u/i): ");
                char opcaoMenu = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome produto: ");
                string nomeProduto = Console.ReadLine();
                Console.WriteLine("Preço produto: ");
                double precoProduto = double.Parse(Console.ReadLine());
                if(opcaoMenu.ToString().ToLower() == "c")
                {
                    produtos.Add(new Produto(nomeProduto, precoProduto));
                }else if(opcaoMenu.ToString().ToLower() == "u")
                {
                    Console.WriteLine("Data de criação? (dia/mes/ano): ");
                    DateTime dataCriacao = DateTime.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoUsado(nomeProduto, precoProduto, dataCriacao));
                }
                else if(opcaoMenu.ToString().ToLower() == "i")
                {
                    Console.WriteLine("Valor imposto: ");
                    double valorImposto = double.Parse(Console.ReadLine());
                    produtos.Add(new ProdutoImportado(nomeProduto, precoProduto, valorImposto));
                }
                else
                {
                    Console.WriteLine("Voce não digitou uma opção de produto valida");
                    i -= 1;
                }

            }
            Console.Clear();

            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.TagPreco());
            }
            Console.ReadLine();
        }
    }
}
