using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicicoFixacaoHeranca
{
    class PessoaFisica : Pessoa
    {
        public double GastoComSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoComSaude) : base(nome, rendaAnual)
        {

        }

        public override double calculaImposto()
        {
            double imposto = 0;
            if(RendaAnual > 20000)
            {
                imposto = RendaAnual * 0.25;
            }
            else
            {
                imposto = RendaAnual * 0.15;
            }
            if(GastoComSaude > 0)
            {
                imposto = imposto - (GastoComSaude * 0.50);
            }

            return imposto;
        }

    }
}
