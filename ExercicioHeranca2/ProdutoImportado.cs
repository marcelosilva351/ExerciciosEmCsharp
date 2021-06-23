using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca2
{
    class ProdutoImportado : Produto
    {
        public double Imposto { get; set; }
        public ProdutoImportado(string nome, double preco, double imposto) : base(nome, preco)
        {
            Imposto = imposto;
        }

        public double PrecoTotal()
        {
            return Preco + Imposto;
        }
        public override string TagPreco()
        {
            return $"Nome: {Nome}, preço: R${PrecoTotal()} (imposto: R${Imposto})";
        }
    }
}
