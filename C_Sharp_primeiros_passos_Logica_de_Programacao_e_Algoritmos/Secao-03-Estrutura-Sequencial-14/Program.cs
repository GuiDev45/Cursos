using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_14
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1009*/

            string nome = Console.ReadLine();
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double venda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = venda * 0.15;
            double total = salario + comissao;

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
