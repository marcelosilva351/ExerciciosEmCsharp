using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAlura
{
    public class Contrato
    {
        public DateTime Data { get; set; }

        public double ValorPorHora { get; set; }

        public int Horas { get; set; }

        public Contrato(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double ValorTotal()
        {
            return ValorPorHora * Horas;
        }
    }
}
