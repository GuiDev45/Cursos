using System;
using Secao_10_Aula_135_Heranca.Entities;

namespace Secao_10_Aula_135_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            //Saída normal.
            Console.WriteLine(account.Balance);

            //Vai acusar erro porque o acesso ao set está protegido.
            //account.Balance = 200.0;
        }
    }
}
