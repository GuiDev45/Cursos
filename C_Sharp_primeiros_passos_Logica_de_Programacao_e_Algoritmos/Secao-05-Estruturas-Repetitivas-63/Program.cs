using System;

namespace Secao_05_Estruturas_Repetitivas_63
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1071*/

            int min = 0;
            int max = 0;
            int soma = 0;

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X < Y) {
                min = X;
                max = Y;
            }
            else {
                min = Y;
                max = X;
            }

            for (int i = min + 1; i < max; i++) {
                if (i % 2 != 0) {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
