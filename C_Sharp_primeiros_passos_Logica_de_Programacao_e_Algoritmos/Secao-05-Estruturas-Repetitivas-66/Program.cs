using System;

namespace Secao_05_Estruturas_Repetitivas_66
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1073*/

            double total = 0;
            
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                    if (i % 2 == 0) {
                    total = Math.Pow(i, 2);
                    Console.WriteLine(i + "^" + 2 + " = " + total);
                }
            }
        }
    }
}
