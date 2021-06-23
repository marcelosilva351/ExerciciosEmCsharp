using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Item
    {
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public Produto produto { get; set; }


        public override string ToString()
        {
            return $"Nome Produto: {produto.Nome}, Preço {Preco}, Quantidade: {Quantidade}, Subtotal: {subTotal()}";
        }
        public Item(int quantidade, double preco, Produto produto)
        {
            Quantidade = quantidade;
            Preco = preco;
            this.produto = produto;
        }

        public double subTotal()
        {
            return Quantidade * Preco;
        }
    }
}
