using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseMetodoAbstrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero de figuras para serem criadas?");
            int numeroFiguras = int.Parse(Console.ReadLine());

            List<Figura> figuras = new List<Figura>();
            for (int i = 0; i < numeroFiguras; i++)
            {
                Console.WriteLine("Retangulo ou circulo? (c/r)");
                char decisaoFiguraCriada = char.Parse(Console.ReadLine());
                Console.WriteLine("Cor: ");
                string cor = Console.ReadLine();          
                if(Enum.TryParse(cor, out Cor corFigura))
                {
                }
                else
                {
                    Console.WriteLine("Não é possivel essa cor");
                    i -= 1;
                    continue;
                }
               

                if (decisaoFiguraCriada.ToString().ToLower() == "r")
                {
                    Console.WriteLine("Largura: ");
                    double largura = double.Parse(Console.ReadLine());
                    Console.WriteLine("Altura: ");
                    double altura = double.Parse(Console.ReadLine());
                    figuras.Add(new Retangulo(altura, largura, corFigura));
                }
                else if (decisaoFiguraCriada.ToString().ToLower() == "c")
                {
                    Console.WriteLine("Raio: ");
                    double raio = double.Parse(Console.ReadLine());
                    figuras.Add(new Circulo(raio, corFigura));
                }
                else
                {
                    Console.WriteLine("Você não digitou uma opção de figura valida");
                    i -= 1;
                }

            }
            foreach (Figura figura in figuras)
            {
                Console.WriteLine(figura);

            }
            Console.ReadLine();

        }
    }
}
