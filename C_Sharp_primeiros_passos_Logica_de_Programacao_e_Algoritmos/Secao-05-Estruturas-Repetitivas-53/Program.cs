using System;
using System.Globalization;

namespace Secao_05_Estruturas_Repetitivas_53
{
    class Program
    {
        static void Main(string[] args){

            int soma = 0;
            int cont = 0;
            double media = 0.0;

            int idade = int.Parse(Console.ReadLine());

            if (idade > 0) {
                while (idade > 0) {
                    cont++;
                    soma += idade;
                    idade = int.Parse(Console.ReadLine());
                }
                media = (double)soma / cont;
                Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
            }
            else {
                Console.WriteLine("impossivel calcular");
            }
        }
    }
}
