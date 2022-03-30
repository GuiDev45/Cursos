using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_11
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1006*/

            //Entrada de dados.
            double A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo matemático.
            double media = ((A * 2.0) + (B * 3.0) + (C * 5.0)) / 10;

            //Saída de dados.
            Console.WriteLine("MEDIA = " + media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
