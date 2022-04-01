using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_19
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1014*/

            //Entrada de dados.
            int X = int.Parse(Console.ReadLine());
            double Y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo matemático.
            double media = X / Y;

            //Saída de dados.
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
