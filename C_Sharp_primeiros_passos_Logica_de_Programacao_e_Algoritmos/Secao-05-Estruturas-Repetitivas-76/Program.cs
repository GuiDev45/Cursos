using System;

namespace Secao_05_Estruturas_Repetitivas_76
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1133*/

            int maior = 0, menor = 0, total = 0;

            int X = int.Parse(Console.ReadLine());
            int Y = int.Parse(Console.ReadLine());

            if (X > Y) {
                maior = X;
                menor = Y;
            } 
            else {
                maior = Y;
                menor = X;
            }

            total = maior - menor - 1;

            for (int i = 0; i < total; i++) {
                menor++;
                if (menor % 5 == 2 || menor % 5 == 3) {
                    Console.WriteLine(menor);
                }
            }
        }
    }
}
