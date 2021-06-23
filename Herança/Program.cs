using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herança.Entites;
namespace Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>();
            accounts.Add(new BusinessAccount(12321, "Alex", 500, 300));
            accounts.Add(new SavingsAccount(13133, "Bob", 500, 0.01));

            foreach (Account conta in accounts)
            {
                Console.WriteLine(conta);
            }

            Console.WriteLine("Saldo total de todas as contas da lista: ");
            double saldoTotalLista = 0;
            foreach (Account conta in accounts)
            {
                saldoTotalLista += conta.Balance;
            }

            Console.WriteLine(saldoTotalLista);
            Console.ReadLine();      

          

           
                
                
        }
    }
}
