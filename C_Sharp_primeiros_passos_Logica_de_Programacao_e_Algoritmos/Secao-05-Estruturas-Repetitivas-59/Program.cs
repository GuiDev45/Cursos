using System;

namespace Secao_05_Estruturas_Repetitivas_59
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1159*/

            int X = int.Parse(Console.ReadLine());

            while (X != 0) {
                int cont = 0;
                int soma = X;
                int total = X;
                if (X % 2 == 0) {
                    while (cont < 4){
                        soma += 2;
                        total += soma;
                        cont++;
                    }
                    Console.WriteLine(total);
                }
                else if (X % 2 != 0) {
                    soma += 1;
                    total += 1;
                    while (cont < 4) {
                        soma += 2;
                        total += soma;
                        cont++;
                    }
                    Console.WriteLine(total);
                }

                X = int.Parse(Console.ReadLine());
            }
        }
    }
}
