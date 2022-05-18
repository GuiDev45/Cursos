using System;
using System.Globalization;

namespace Secao_05_Aula_060_Exercicio_de_fixacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();

            Conta conta = new Conta(numeroConta, nomeTitular);

            Console.Write("Haverá depósito inicial (s/n)? ");
            char decisaoInicial = char.Parse(Console.ReadLine());

            if (decisaoInicial == 's' || decisaoInicial == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta.Deposito(valorInicial);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }
            else if (decisaoInicial == 'n' || decisaoInicial == 'N')
            {
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }

            Console.WriteLine();

            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.WriteLine();

            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

        }
    }
}
