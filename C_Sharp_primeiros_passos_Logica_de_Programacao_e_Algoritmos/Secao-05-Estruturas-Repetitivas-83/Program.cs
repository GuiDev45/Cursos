using System;
using System.Globalization;

namespace Secao_05_Estruturas_Repetitivas_83
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1156*/

            double S = 0;
            double par = 1;
            double impar = 1;

            while (impar != 39) {
                S += impar / par;
                impar += 2;
                par += par;
            }

            Console.WriteLine(S.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
