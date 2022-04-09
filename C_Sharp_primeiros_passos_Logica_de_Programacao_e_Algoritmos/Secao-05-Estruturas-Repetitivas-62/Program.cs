using System;

namespace Secao_05_Estruturas_Repetitivas_62
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1078*/

            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++) {
                int resultado = i * N;
                Console.WriteLine(i + " x " + N + " = " + resultado);
            }
        }
    }
}
