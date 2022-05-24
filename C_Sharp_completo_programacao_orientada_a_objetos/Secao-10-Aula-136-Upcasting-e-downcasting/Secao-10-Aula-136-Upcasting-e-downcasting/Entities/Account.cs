using System;
using System.Collections.Generic;
using System.Text;

namespace Secao_10_Aula_136_Upcasting_e_downcasting.Entities
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

        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
