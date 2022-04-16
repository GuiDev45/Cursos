using System;
using System.Globalization;

namespace Secao_06_Vetores_95
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            4) Fazer um programa para ler um vetor de N números reais. Em seguida, mostrar na tela a média aritmética de todos elementos.
            Depois mostrar todos os elementos do vetor que estejam abaixo da média.
            Exemplo:
            Entrada                                         Saída
            4                                               12.125
            10.0 15.5 13.2 9.8                              10.0
                                                            9.8
            */

            Console.Write("Quantos números reais vão ser digitados ?: ");
            int N = int.Parse(Console.ReadLine());

            double[] num = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            double soma = 0.0;
            
            for (int i = 0; i < N; i++) {
                num[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                soma += num[i];
            }

            Console.WriteLine();

            double media = 0.0;
            media = soma / N;
            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture));

            for (int i = 0; i < N; i++) {
                if (num[i] < media) {
                    Console.WriteLine(num[i].ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
