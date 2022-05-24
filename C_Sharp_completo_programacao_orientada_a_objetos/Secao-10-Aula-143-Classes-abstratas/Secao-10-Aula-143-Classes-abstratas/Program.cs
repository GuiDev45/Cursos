using System;
using System.Globalization;
using System.Collections.Generic;
using Secao_10_Aula_143_Classes_abstratas.Entities;

namespace Secao_10_Aula_143_Classes_abstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mesmo a classe Account sendo abstrata, é ´possível criar uma lista do tipo Account.
            List<Account> list = new List<Account>();

            //Caso a classe Account não fosse abstrata/generica, não seria possível adicionar dois tipo diferentes na mesma lista,
            //como é o caso de SavingsAccount e BusinessAccount fazendo a herança da classe abstrata Account.
            list.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            list.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            list.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            list.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            //Pelo fato de poder adicionar tipos diferentes na lista,
            //uma operação para somar os valores de todas as contas, se torna mais fácil.
            double sum = 0.0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2", CultureInfo.InvariantCulture));
            //Saída - Total balance: 2000.00

            //Um foreach para sacar 10.0 de cada conta, se torna mais fácil também.
            foreach (Account acc in list)
            {
                acc.Withdraw(10.0);
            }

            //Para cada acc em lista imprima conta por conta.
            foreach(Account acc in list)
            {
                Console.WriteLine("Updated balance for account" 
                    + acc.Number 
                    + ": " 
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
