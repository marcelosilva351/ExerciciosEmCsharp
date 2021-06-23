using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herança.Entites
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

       public  BusinessAccount()
        {

        }

        public BusinessAccount(int number, string holder, double balance, double loanLimite) : base(number, holder, balance)
        {
            LoanLimit = loanLimite;
        }
        public void Loan(double Amount)
        {
            if (Amount <= LoanLimit)
            {
                Balance += Amount;
            }
        }

        public override string ToString()
        {
            return $"Number: {Number}, Holder: {Holder}, Balance: ${Balance}, LoanLimite: {LoanLimit}";
        }
    }
}
