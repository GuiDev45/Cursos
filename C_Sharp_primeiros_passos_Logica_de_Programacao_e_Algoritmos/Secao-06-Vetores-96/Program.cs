using System;
using System.Globalization;

namespace Secao_06_Vetores_96
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            5) Fazer um programa para ler um vetor de N números inteiros. Em seguida, mostrar na tela a média aritmética somente
            dos números pares lidos.
            Exemplo:
            Entrada                                 Saída
            6                                       11.0
            8 2 11 14 13 20
            */

            Console.Write("Quantos números inteiros vão ser digitados ?: ");
            int N = int.Parse(Console.ReadLine());

            int[] num = new int[N];

            Console.WriteLine("Digite os números inteiros:");
            string[] s = Console.ReadLine().Split(' ');

            double soma = 0.0;
            double media = 0.0;
            int par = 0;

            for (int i = 0; i < N; i++) {
                num[i] = int.Parse(s[i]);
                
                if (num[i] % 2 == 0) {
                    soma += num[i];
                    par++;
                }
            }

            Console.WriteLine();

            media = soma / par;
            Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}
