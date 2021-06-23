using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entites
{
    public class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {

        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        
        public void UpdateBalance()
        {
            Balance = Balance * InterestRate;
        }

        public override void withDraw(double amount)
        {
            base.withDraw(amount);
            Balance -= 2;
        }

        public override string ToString()
        {
            return  $"Number: {Number}, Holder: {Holder}, Balance: ${Balance}, Interest Rate: {InterestRate}";
        }
    }
}
