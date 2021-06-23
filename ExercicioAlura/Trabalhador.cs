using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioAlura;
namespace ExercicioAlura
{
     class Trabalhador
    {
        public string Nome { get; set; }
        public Departamento departamento { get; set; }
        public string Level { get; set; }
        public double SalarioBase { get; set; }

        List<Contrato> contratos = new List<Contrato>();

        public Trabalhador(string nome, Departamento departamento, string level, double salarioBase)
        {
            Nome = nome;
            this.departamento = departamento;
            Level = level;
            SalarioBase = salarioBase;
        }

        public void AddContrato(Contrato contrato)
        {
            contratos.Add(contrato);
        }

        public double pesquisaValorPorData(int mes, int ano)
        {
            double resultado = SalarioBase;
            foreach (Contrato contrato in contratos)
            {
                if(contrato.Data.Month == mes && contrato.Data.Year == ano)
                {
                  resultado += contrato.ValorTotal();
                }

            }
              return resultado;
        }
    }
}
