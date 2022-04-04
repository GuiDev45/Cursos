using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_31
{
    class Program
    {
        static void Main(string[] args){
            //Declaração de variáveis.
            double plano = 50.0;

            //Entrada de dados.
            int minutos = int.Parse(Console.ReadLine());

            //Estrutura Condicional.
            if (minutos > 100) {
                plano += (minutos - 100) * 2.0;
            }

            //Saída de dados.
            Console.WriteLine("Valor a pagar: R$ " + plano.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
