using System;
using System.Globalization;

namespace Secao_06_Vetores_91
{
    class Program
    {
        static void Main(string[] args){
            /*Exercício resolvido 03*/

            double soma = 0.0;
            double media = 0.0;
            double porcentagem = 0.0;
            int cont = 0;

            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            int[] idade = new int[N];
            double[] altura = new double[N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');

                nome[i] = (s[0]);
                idade[i] = int.Parse(s[1]);
                altura[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
                soma += altura[i];

                if (idade[i] < 16) {
                    cont++;
                }
            }
            Console.WriteLine();

            media = soma / N;
            Console.WriteLine("Altura média: " + media.ToString("F2", CultureInfo.InvariantCulture));

            porcentagem = (double)cont / N * 100;
            Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1", CultureInfo.InvariantCulture) + "%");
        }
    }
}
