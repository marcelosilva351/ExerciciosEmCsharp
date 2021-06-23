using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicicoFixacaoHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas = new List<Pessoa>();
            Console.WriteLine("Numero de pagantes de impostos?");
            int numeroPagantesImpostos = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeroPagantesImpostos; i++)
            {
                Console.WriteLine("Pessoa fisica ou Juridica?[f][j]");
                char FisicaOuJuridica = char.Parse(Console.ReadLine());
                Console.WriteLine("Nome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine());
                if(FisicaOuJuridica.ToString().ToLower() == "f")
                {
                    Console.WriteLine("Gastos com saude: ");
                    double gastosComSaude = double.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaFisica(nome, rendaAnual, gastosComSaude));

                }
                else if(FisicaOuJuridica.ToString().ToLower() == "j")
                {
                    Console.WriteLine("Numero de funcionarios? ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(nome, rendaAnual, numeroDeFuncionarios));
                }       
            }

            Console.Clear();
            Console.WriteLine("IMPOSTOS: ");
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa);
            }



            double numeroTotalImpostos = 0;
            foreach (Pessoa pessoa in pessoas)
            {
                numeroTotalImpostos += pessoa.calculaImposto();
            }
            Console.WriteLine("Numero Total de impostos: " + numeroTotalImpostos);

            Console.ReadLine();

        }
    }
}
