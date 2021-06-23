using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entites
{
    public abstract class Account
    {
        public int Number { get; }
        public string Holder { get; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void withDraw(double amount)
        {
            Balance = (Balance - 5) - amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        

    }
}
