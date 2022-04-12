using System;
using System.Globalization;

namespace Secao_05_Estruturas_Repetitivas_74
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1116*/

            double resultado = 0.0;
            int cont = 0;

            int N = int.Parse(Console.ReadLine());

            while (cont < N) {
                string[] vet = Console.ReadLine().Split(' ');
                double X = double.Parse(vet[0]);
                double Y = double.Parse(vet[1]);

                if (Y != 0) {
                    resultado = X / Y;
                    Console.WriteLine(resultado.ToString("F1", CultureInfo.InvariantCulture));
                }
                else {
                    Console.WriteLine("divisao impossivel");
                }

                cont++;
            }
        }
    }
}
