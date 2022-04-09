using System;
using System.Globalization;

namespace Secao_05_Estruturas_Repetitivas_58
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1154*/

            double idade = 0.0, media = 0.0, soma = 0.0;
            int cont = 0;

            idade = double.Parse(Console.ReadLine());

            while (idade > 0) {
                soma += idade;
                cont++;
                idade = double.Parse(Console.ReadLine());
            }

            media = soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
