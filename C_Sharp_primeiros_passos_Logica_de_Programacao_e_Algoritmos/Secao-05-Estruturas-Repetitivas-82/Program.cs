using System;
using System.Globalization;

namespace Secao_05_Estruturas_Repetitivas_82
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1155*/

            double S = 1.0;

            for (int i = 2; i <= 100; i++) {
                S += (double) 1 / i;
            }

            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
