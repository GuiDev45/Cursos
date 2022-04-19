using System;

namespace Secao_07_Matrizes_102
{
    class Program
    {
        static void Main(string[] args){
            int M = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            
            int[,] mat = new int [M, N];

            string[] s = Console.ReadLine().Split(' ');

            for (int i = 0; i < M; i++) {
                s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int[] vetSoma = new int[M];

            for (int i = 0; i < M; i++) {
                int soma = 0;
                for (int j = 0; j < N; j++) {
                    soma += mat[i, j];
                }
                vetSoma[i] = soma;
            }

            for (int i = 0; i < M; i++) {
                Console.WriteLine(vetSoma[i]);
            }
        }
    }
}
