using System;

namespace Secao_06_Vetores_94
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            3) Faça um programa para ler dois vetores A e B, contendo N elementos cada. Em seguida, gere um terceiro vetor C onde
            cada elemento de C é a soma dos elementos correspondentes de A e B. Imprima o vetor C gerado.
            Entrada                               Saída
            6                                     13 12 14 15 23 27
            8 2 11 14 13 20
            5 10 3 1 10 7
            */

            Console.Write("Quantos números inteiros vão ser digitados ?: ");
            int N = int.Parse(Console.ReadLine());

            int [] A = new int[N];
            int [] B = new int[N];
            int [] C = new int[N];

            Console.WriteLine("Digite os números inteiros:");
            string[] a = Console.ReadLine().Split(' ');
            string[] b = Console.ReadLine().Split(' ');

            Console.WriteLine();

            for (int i = 0; i < N; i++) {
                A[i] = int.Parse(a[i]);
                B[i] = int.Parse(b[i]);
                C[i] = A[i] + B[i];

                Console.Write(C[i] + " ");
            }
        }
    }
}
