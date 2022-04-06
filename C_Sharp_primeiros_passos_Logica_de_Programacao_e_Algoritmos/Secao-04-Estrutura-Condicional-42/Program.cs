using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_42
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1051*/

            double resto = 0.0, calculo = 0.0;

            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            if (valor <= 2000.0) {
                Console.WriteLine("Isento");
            }
            else {
                if (valor > 2000.0 && valor <= 3000.0) {
                    valor += - 2000.0;
                    calculo = valor * 8.0 / 100.0;
                } 
                else if (valor > 3000.0 && valor <= 4500.0) {
                    resto = 1000.0;
                    calculo = resto * 8.0 / 100.0;
                    valor = valor - 3000.0;
                    calculo += ((valor * 18.0) / 100.0);
                } 
                else {
                    resto = 1000.0;
                    calculo = resto * 8.0 / 100.0;
                    resto = 1500.0;
                    calculo += ((resto * 18.0) / 100.0);
                    valor = valor - 4500.0;
                    calculo += ((valor * 28.0) / 100.0);
                }
                Console.WriteLine("R$ " + calculo.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
