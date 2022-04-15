using System;

namespace Secao_06_Vetores_93
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            2) Faça um programa que leia N números inteiros e armazene-os em um vetor. Em seguida, mostre na tela:
            - todos os números pares
            - a quantidade de números pares
            Entrada                         Saída
            6                               8 2 14 20
            8 2 11 14 13 20                 4
            */

            Console.Write("Quantos números inteiros vão ser digitados ?: ");
            int N = int.Parse(Console.ReadLine());

            int[] num = new int[N];

            Console.WriteLine("Digite os números inteiros:");
            string[] s = Console.ReadLine().Split(' ');

            Console.WriteLine();

            int quantidadePar = 0;
            for (int i = 0; i < N; i++) {
                num[i] = int.Parse(s[i]);

                if (num[i] % 2 == 0) {
                    Console.Write(s[i] + " ");
                    quantidadePar++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(quantidadePar);
        }
    }
}
