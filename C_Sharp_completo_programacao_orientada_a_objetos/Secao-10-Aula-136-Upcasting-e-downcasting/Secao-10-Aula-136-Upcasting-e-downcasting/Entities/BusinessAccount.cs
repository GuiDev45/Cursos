using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_136_Upcasting_e_downcasting.Entities
{
    // : (significa estende), estende quem ? a classe Account.
    internal class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        // : base(), dessa forma se chama os atributos da classe que está sendo herdada, base() é a referência para a superclasse.
        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        //Método de empréstimo.
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}