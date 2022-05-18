using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao_05_Aula_060_Exercicio_de_fixacao
{
    internal class Conta
    {
        public int NumeroConta { get; private set; }//Está private porque o número não pode ser alterado.
        public string NomeTitular { get; set; }//O nome do titular pode ser alterado então vai ser get e set public.
        public double SaldoConta { get; private set; }//Está private porque o saldo da conta não pode ser alterado, apenas pelos métodos Deposito ou Saque.

        public Conta(int numeroConta, string nomeTitular)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            SaldoConta = 0.0;//Não precisava colocar o SaldoConta recebendo 0.0, foi só uma opção particular.
        }

        public void Deposito(double deposito)
        {
            SaldoConta += deposito;
        }
        public void Saque(double saque)
        {
            SaldoConta -= saque + 5.0;
        }

        public override string ToString()
        {
            return "Conta " 
                + NumeroConta 
                + ", Titular: " 
                + NomeTitular 
                + ", Saldo: $ " 
                + SaldoConta.ToString("F2", CultureInfo.InvariantCulture); 
        }
    }
}
