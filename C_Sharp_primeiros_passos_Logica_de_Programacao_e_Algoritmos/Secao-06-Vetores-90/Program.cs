using System;
using System.Globalization;

namespace Secao_06_Vetores_90
{
    class Program
    {
        static void Main(string[] args){
            /*Exercício resolvido 02*/
            
            double soma = 0.0;
            double media = 0.0;

            int N = int.Parse(Console.ReadLine());

            double[] num = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                num[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
                soma += num[i];
                Console.Write(num[i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            media = soma / N;

            Console.WriteLine(soma.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
