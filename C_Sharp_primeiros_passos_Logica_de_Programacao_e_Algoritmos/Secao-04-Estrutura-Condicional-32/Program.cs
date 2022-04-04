using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_32
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1037*/

            //Entrada de dados.
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Estrutura Condicional e saída de dados.
            if (valor >= 0.0 && valor <= 25.0) {
                Console.WriteLine("Intervalo [0,25]");
            } 
            else if (valor > 25.0 && valor <= 50.0) {
                Console.WriteLine("Intervalo (25,50]");
            } 
            else if (valor > 50.0 && valor <= 75.0) {
                Console.WriteLine("Intervalo (50,75]");
            } 
            else if (valor > 75.0 && valor <= 100.0) {
                Console.WriteLine("Intervalo (75,100]");
            } 
            else {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
