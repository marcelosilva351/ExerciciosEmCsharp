using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HenracaExercicio1.Entidades;

namespace HenracaExercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionarios vão ser cadastrados?");
            int numeroFuncionariosCadastrar = int.Parse(Console.ReadLine());
            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < numeroFuncionariosCadastrar; i++)
            {
                Console.WriteLine($"Dados funcionario #{i+1}");
                Console.WriteLine("Terceirizado [s][n]");
                string funcionarioTerceirazado = Console.ReadLine();
                Console.WriteLine("Nome funcionario: ");
                string nomeFuncionario = Console.ReadLine();
                Console.WriteLine("Horas trabalhadas: ");
                int horasTrabalhadas = int.Parse(Console.ReadLine());
                Console.WriteLine("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine());
                if(funcionarioTerceirazado.ToLower() == "s")
                {
                    Console.WriteLine("Adicional: ");
                    double adicional = double.Parse(Console.ReadLine());
                    funcionarios.Add(new FuncionarioTerceirazado(nomeFuncionario, horasTrabalhadas, valorPorHora,adicional));
                }
                else
                {
                    funcionarios.Add(new Funcionario(nomeFuncionario, horasTrabalhadas, valorPorHora));
                }

            }
            Console.WriteLine("Pagamentos: ");
            foreach (Funcionario funcionario in funcionarios)
            {
                Console.WriteLine($"{funcionario.Nome}: R${funcionario.Pagamento()}");

            }
            Console.ReadLine();
        }
    }
}
