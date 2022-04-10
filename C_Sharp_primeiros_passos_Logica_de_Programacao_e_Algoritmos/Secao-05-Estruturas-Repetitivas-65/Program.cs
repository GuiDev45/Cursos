using System;

namespace Secao_05_Estruturas_Repetitivas_65
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1072*/

            int contIn = 0;
            int contOut = 0;
            int X = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                X = int.Parse(Console.ReadLine());
                
                if (X >= 10 && X <= 20) {
                contIn++;
                }
                else {
                contOut++;
                }
            }

            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}
