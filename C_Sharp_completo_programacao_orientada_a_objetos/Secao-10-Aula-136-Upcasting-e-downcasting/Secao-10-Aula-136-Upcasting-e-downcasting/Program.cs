using System;
using Secao_10_Aula_136_Upcasting_e_downcasting.Entities;

namespace Secao_10_Aula_136_Upcasting_e_downcasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            //Como a herança é uma relação É UM, então o tipo Account aceita o tipo BusinessAccount
            //Porque o BusinessAccount também é uma Account.
            Account acc1 = bacc;

            //Essa forma também é possivel.
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);

            //Como SavingsAccount também é uma sub classe, esse é outro exemplo possivel.
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING
            //Essa forma acusaria erro, porque não pode converter a subclasse em superclasse implicitamente.
            //BusinessAccount acc4 = acc2;

            //É necessário fazer um casting para a superclasse aceitar.
            BusinessAccount acc4 = (BusinessAccount)acc2;
            //Como exemplo que deu certo é possível invocar o empréstimo por exemplo.
            acc4.Loan(100.0);

            //Isso acusaria erro, porque o Loan está apenas em BusinessAccount/subclasse, e o acc2 é do tipo Account/superclasse
            //acc2.Loan(100.0)

            //Apesar de não estar acusando erro, na hora de compilar vai acusar, porque por mais que o casting tenha acontecido,
            //o acc3 é do tipo SavingsAccount, e SavingsAccount é subclasse de Account, assim como BusinessAccount,
            //BusinessAccount e SavingsAccount não estão ligadas entre elas.
            BusinessAccount acc5 = (BusinessAccount)acc3;

            //Essa é uma forma de testar antes de rodas o código,
            //esse 'is' pergunta se acc3 for do tipo BusinessAccount então pode rolar o casting.  
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc6 = (BusinessAccount)acc3;
            }

            //Uma outra forma de casting é fazer
            BusinessAccount acc7 = acc3 as BusinessAccount;//É o mesmo que BusinessAccount acc7 = (BusinessAccount)acc3;
        }
    }
}
