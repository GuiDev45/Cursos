using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_138_Classes_e_metodos_selados.Entities
{
    // : (significa estende), estende quem ? a classe Account.
    // sealed, não deixa criar subclasse a partir dessa classe.
    sealed class SavingsAccount : Account
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

        //override, está sobreescrevendo o método da superclasse Account,
        //e esse método por estar sendo sobreescrito pode ter novas regras.
        //a regra desse método é que vai descontar a taxa de 5.0 do método que está na classe Account,
        //e depois descontar mais 2.0

        //sealed, significa que esse método não pode ser reescrito novamente em uma outra subclasse.
        //é sempre bom selar métodos sobrepostos, sobreposições multiplas pode ser uma porta de entrada para inconsistências.
        public sealed override void Withdraw(double amount)
        {
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}