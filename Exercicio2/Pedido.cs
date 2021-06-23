using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Pedido
    {
        public DateTime Momento { get; set; }
        public string StatusPedido { get; set; }

        public Cliente cliente { get; set; }

        public List<Item> itens = new List<Item>();
        public Pedido( string statusPedido, Cliente cliente)
        {
            Momento = DateTime.Now;
            StatusPedido = statusPedido;
            this.cliente = cliente;
        }

        public void AddItem(Item item)
        {
            itens.Add(item);
        }

        public void RemoveItem(Item item)
        {
            itens.Remove(item);
        }

        public double totalPedido()
        {
            double total = 0;
            foreach(Item item in itens)
            {
                total += item.subTotal();
            }
            return total;
        }


    }
}
