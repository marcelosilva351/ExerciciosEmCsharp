using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseMetodoAbstrato
{
    abstract class Figura
    {    
        public Cor Cor { get; set; }

        public Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
