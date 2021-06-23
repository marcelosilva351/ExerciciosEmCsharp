using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseMetodoAbstrato
{
    class Circulo : Figura
    {
        public double Raio { get; set; }

        public Circulo(double raio, Cor cor) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return 3.14 * (Raio * Raio);
        }

        public override string ToString()
        {
            return $"Circulo, Area: {Area().ToString("F2")}, Cor: {Cor}";
        }
    }
}
