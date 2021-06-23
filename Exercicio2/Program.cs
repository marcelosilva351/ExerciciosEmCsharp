using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do cliente");
            Console.WriteLine("Nome: ");
            string nomeCliente = Console.ReadLine();
            Console.WriteLine("Email: ");
            string emailCliente = Console.ReadLine();
            Console.WriteLine("Data de nascimeneto (dia/mes/ano): ");
            DateTime dataNascimentoCliente = DateTime.Parse(Console.ReadLine());
            Cliente cliente = new Cliente(nomeCliente, emailCliente, dataNascimentoCliente);
            Console.Clear();
            Console.WriteLine("Entre com os dados do pedido");
            string statusPedido = Console.ReadLine();
            Pedido pedido = new Pedido(statusPedido, cliente);
            Console.WriteLine("Quantos itens nesse pedido: ");
            int quantidadePedidos = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadePedidos; i++)
            {
                Console.WriteLine("Nome do produto: ");
                string nomeProduto = Console.ReadLine();
                Console.WriteLine("Preço: ");
                double precoProdudto = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantidade: ");
                int quantidadeProduto = int.Parse(Console.ReadLine());
                Produto produto = new Produto(nomeProduto,precoProdudto);
                Item item = new Item(quantidadeProduto, precoProdudto, produto);
                pedido.AddItem(item);
                
            }
            Console.Clear();
            Console.WriteLine("Informações pedido");
            Console.WriteLine("Data Pedido: " + pedido.Momento);
            Console.WriteLine("Status Pedido " + pedido.StatusPedido);
            Console.WriteLine("Cliente " + cliente);
            Console.WriteLine("Items pedido: ");
            foreach (Item item in pedido.itens)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("TOTAL DO PEDIDO: " + pedido.totalPedido());
            Console.ReadLine();
        }
    }
}
