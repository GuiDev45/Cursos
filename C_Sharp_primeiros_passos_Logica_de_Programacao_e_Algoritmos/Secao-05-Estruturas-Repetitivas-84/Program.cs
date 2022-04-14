using System;

namespace Secao_05_Estruturas_Repetitivas_84
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1157*/

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) {
                if (N % i == 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
