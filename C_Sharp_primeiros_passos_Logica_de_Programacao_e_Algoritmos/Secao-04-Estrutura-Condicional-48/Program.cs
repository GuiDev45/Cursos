using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_48
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1064*/

            int positivo = 0;
            double soma = 0.0;

            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num1 > 0.0) {
                positivo += 1;
                soma += num1;
            }
            if (num2 > 0.0) {
                positivo += 1;
                soma += num2;
            }
            if (num3 > 0.0) {
                positivo += 1;
                soma += num3;
            }
            if (num4 > 0.0) {
                positivo += 1;
                soma += num4;
            }
            if (num5 > 0.0) {
                positivo += 1;
                soma += num5;
            }
            if (num6 > 0.0) {
                positivo += 1;
                soma += num6;
            }

            double media = soma / positivo;

            Console.WriteLine(positivo + " valores positivos");
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
