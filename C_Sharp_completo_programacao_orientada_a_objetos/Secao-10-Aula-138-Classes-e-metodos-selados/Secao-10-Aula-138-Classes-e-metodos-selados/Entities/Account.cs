using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_138_Classes_e_metodos_selados.Entities
{
    internal class Account
    {
        //Encapsulando com o private.
        public int Number { get; private set; }
        public string Holder { get; private set; }
        //protected, o set só poder ser usado nessa classe Account ou em sua subclasse, no caso BusinessAccount
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

        //virtual, significa que esse método pode ser sobreposto nas subclasses.
        //a regra desse método é que amount vai receber + 5.0
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}