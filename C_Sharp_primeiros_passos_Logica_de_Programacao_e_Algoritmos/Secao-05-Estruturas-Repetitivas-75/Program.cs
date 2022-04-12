using System;

namespace Secao_05_Estruturas_Repetitivas_75
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1132*/

            int soma = 0;
            int maior, menor;

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X >= Y) {
                maior = X;
                menor = Y;
            } 
            else {
                maior = Y;
                menor = X;
            }

            for (int i = menor; i <= maior; i++) {
                if (i % 13 != 0) {
                    soma += i;
                }
            }

            Console.WriteLine(soma);
        }
    }
}
