using System;
using System.Globalization;

namespace Secao_05_Estruturas_Repetitivas_69
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1079*/

            double media = 0.0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                double valor1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
                double valor2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
                double valor3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

                media = ((valor1 * 2) + (valor2 * 3) + (valor3 * 5)) / 10;
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
