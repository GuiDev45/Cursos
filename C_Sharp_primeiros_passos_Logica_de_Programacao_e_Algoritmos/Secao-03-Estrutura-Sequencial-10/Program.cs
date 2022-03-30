using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_10
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1005*/

            //Entrada de dados.
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo matemático.
            double media = ((A * 3.5) + (B * 7.5)) / 11;

            //Saída de dados.
            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
