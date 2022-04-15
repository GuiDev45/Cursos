using System;

namespace Secao_06_Vetores_89
{
    class Program
    {
        static void Main(string[] args) {
            /*Exercício resolvido 01*/

            int N;
            int[] vet;

            N = int.Parse(Console.ReadLine());
            vet = new int[N]; //Alocação na memória

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < N; i++) {
                vet[i] = int.Parse(s[i]);
            }

            for (int i = 0; i < N; i++) {
                if (vet[i] < 0) {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
