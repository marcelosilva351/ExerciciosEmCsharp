using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseMetodoAbstrato
{
    class Retangulo : Figura
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo(double altura, double largura, Cor cor) : base(cor)
        {
            Altura = altura;
            Largura = largura;
        }

        public override double Area()
        {
            return Altura * Largura;
        }

        public override string ToString()
        {
            return $"Retangulo, Area: {Area().ToString("F2")}, Cor: {Cor}";
        }
    }
}
