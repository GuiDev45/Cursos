using System;

namespace Secao_05_Estruturas_Repetitivas_68
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1075*/

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++) {
                if (i % N == 2) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
