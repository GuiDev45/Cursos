using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_47
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1060*/

            int positivo = 0;

            double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double num6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num1 > 0.0) {
                positivo += 1;
            }
            if (num2 > 0.0) {
                positivo += 1;
            }
            if (num3 > 0.0) {
                positivo += 1;
            }
            if (num4 > 0.0) {
                positivo += 1;
            }
            if (num5 > 0.0) {
                positivo += 1;
            }
            if (num6 > 0.0) {
                positivo += 1;
            }

            Console.WriteLine(positivo + " valores positivos");
        }
    }
}
