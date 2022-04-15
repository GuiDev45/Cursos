using System;
using System.Globalization;

namespace Secao_06_Vetores_92
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            1) Faça um programa que leia N números reais e armazene-os em um vetor. Em seguida, mostrar na tela o maior número
            do vetor (supor não haver empates). Mostrar também a posição do maior elemento.
            Entrada                                 Saída
            6                                       14.0
            8.0 4.0 10.0 14.0 13.0 7.0              3
            */

            Console.Write("Quantos números reais vão ser digitados ?: ");
            int N = int.Parse(Console.ReadLine());

            double[] num = new double[N];

            Console.WriteLine("Digite os números reais:");
            string[] s = Console.ReadLine().Split(' '); 

            Console.WriteLine();

            double maior = 0.0;
            int maiorPosicao = 0;

            for (int i = 0; i < N; i++) {
                num[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                if (num[i] > maior) {
                    maior = num[i];
                    maiorPosicao = i;
                }
            }

            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(maiorPosicao);
        }
    }
}
