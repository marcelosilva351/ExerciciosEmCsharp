using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicicoFixacaoHeranca
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double renda, int numFuncionarios) : base(nome, renda)
        {
            NumeroFuncionarios = numFuncionarios;
        }

        public override double calculaImposto()
        {
            double imposto = 0;
            if (NumeroFuncionarios > 10)
            {
                 imposto = RendaAnual * 0.16;
            }
            else
            {
                imposto = RendaAnual * 0.14;
            }
            return imposto;
        }

      
    }
}
