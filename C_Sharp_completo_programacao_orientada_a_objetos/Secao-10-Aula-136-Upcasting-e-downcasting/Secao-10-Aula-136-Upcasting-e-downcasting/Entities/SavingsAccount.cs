using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_136_Upcasting_e_downcasting.Entities
{
    // : (significa estende), estende quem ? a classe Account.
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        // : base(), dessa forma se chama os atributos da classe que está sendo herdada, base() é a referência para a superclasse.
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        //Método para atualizar a taxa de juros.
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
