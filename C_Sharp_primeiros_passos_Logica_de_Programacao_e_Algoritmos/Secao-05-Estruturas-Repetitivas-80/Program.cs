using System;

namespace Secao_05_Estruturas_Repetitivas_80
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1151*/

            int anterior = 0;
            int atual = 0;
            int proximo = 1;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {

                if (N == 1) {
                    Console.Write(atual);
                }
                else if (i < 1) {
                    atual = i;
                    Console.Write(atual + " ");
                    atual = proximo;
                    Console.Write(atual);
                    anterior = atual;
                    i++;
                }
                else {
                    atual = proximo;
                    Console.Write(" " + atual);

                    proximo = atual + anterior;
                    anterior = atual;
                }
            }

            Console.WriteLine();
        }
    }
}
