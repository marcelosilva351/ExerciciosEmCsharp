using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExercicioAlura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nome departamento");
            string nomeDepartamento = Console.ReadLine();
            Console.WriteLine("Dados do trabalhador");
            Console.WriteLine("Nome trabalhador:");
            string nomeTrabalhador = Console.ReadLine();
            Console.WriteLine("Nivel do trabalhaor (junior/senior/pleno): ");
            string level = Console.ReadLine();
            Console.WriteLine("Salario base:");
            double salarioBase = double.Parse(Console.ReadLine());
            Departamento departamento = new Departamento();
            departamento.Nome = nomeDepartamento;
            Trabalhador trabalhador = new Trabalhador(nomeTrabalhador, departamento, level, salarioBase);
            Console.Clear();
            Console.WriteLine($"Nome: {trabalhador.Nome}, Departamento: {departamento}, level: {level}, Salario Base: {salarioBase} ");
            Console.WriteLine("Quantos contratos para esse trabalhador");
            int quantidadeFuncionarios = int.Parse(Console.ReadLine());
            for (int i = 0; i < quantidadeFuncionarios; i++)
            {
                Console.WriteLine($"Dados contrato {i+1}: ");
                Console.WriteLine("Digite a data: (dia/mes/ano)");
                string dataContratoString = Console.ReadLine();
                DateTime dataContrato = DateTime.Parse(dataContratoString);
                Console.WriteLine("Valor por hora:");
                double valorPorHora = double.Parse(Console.ReadLine());
                Console.WriteLine("Duração contrato: ");
                int duracaoContrato = int.Parse(Console.ReadLine());
                Contrato contrato = new Contrato(dataContrato, valorPorHora, duracaoContrato);
                trabalhador.AddContrato(contrato);
            }

            Console.WriteLine("Digite o mes e ano para pesquisar valor contrato: (mes/ano)");
            string mesAnoUsuario = Console.ReadLine();
            int mes = int.Parse(mesAnoUsuario.Substring(0, 2));

            int ano = int.Parse(mesAnoUsuario.Substring(3));

            double resultadoValorContratoTrabalhador = trabalhador.pesquisaValorPorData(mes, ano);
            Console.WriteLine($"Resultado valor dos contratos de {mesAnoUsuario}");
            Console.WriteLine(resultadoValorContratoTrabalhador);
            Console.ReadLine();

        }
    } 
    
}
