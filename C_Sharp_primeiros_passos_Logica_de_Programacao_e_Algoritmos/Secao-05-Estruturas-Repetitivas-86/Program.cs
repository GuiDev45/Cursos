using System;

namespace Secao_05_Estruturas_Repetitivas_86
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1101*/

            string[] valores = Console.ReadLine().Split(' ');

            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            int maior, menor, soma;

            while (M > 0 && N > 0) {
                soma = 0;
                maior = 0;
                menor = 0;

                if (M >= N) {
                    maior = M;
                    menor = N;
                } 
                else {
                    maior = N;
                    menor = M;
                }

                for (int i = menor; i <= maior; i++) {
                    Console.Write(i + " ");
                    soma += i;
                }

                Console.WriteLine("Sum=" + soma);

                valores = Console.ReadLine().Split(' ');

                M = int.Parse(valores[0]);
                N = int.Parse(valores[1]);
            }
        }
    }
}
