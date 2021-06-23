using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenracaExercicio1.Entidades
{
    class FuncionarioTerceirazado : Funcionario
    {
        
        public double Adicional { get; set; }

        public FuncionarioTerceirazado(string nome, int horas, double valorPorHora, double adicional) : base(nome, horas, valorPorHora)
        {
            Adicional = adicional;
        }


        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * Adicional;
        }
    }
}
