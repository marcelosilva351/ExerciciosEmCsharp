using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca2
{
    class ProdutoUsado : Produto
    {
        public DateTime DataCriacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataCriacao) : base(nome, preco)
        {
            DataCriacao = dataCriacao;
        }

        public override string TagPreco()
        {
            return $"Nome: {Nome} (Produto usado), preço: R${Preco}, Data de fabricação {DataCriacao.ToString("dd/MM/yyyy")}";
        }
    }
}
