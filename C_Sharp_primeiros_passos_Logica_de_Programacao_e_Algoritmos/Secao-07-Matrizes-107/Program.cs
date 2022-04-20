using System;

namespace Secao_07_Matrizes_107
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            5) Fazer um programa para ler duas matrizes de números inteiros A e B, contendo de M linhas e N colunas cada. Depois,
            gerar uma terceira matriz C onde cada elemento desta é a soma dos elementos correspondentes das matrizes originais.
            Imprimir na tela a matriz gerada.

            Entrada:
            A entrada contém os valores de M e N, depois os valores da primeira matriz A, depois os valores da segunda matriz B,
            conforme exemplo.

            Saída:
            A saída contém os valores da matriz gerada C, conforme exemplo.
            Exemplo:
            Entrada                     Saída
            2 3                         5 9 7
            3 5 2                       5 13 9
            4 5 1
            2 4 5
            1 8 8
            */

            string[] valores = Console.ReadLine().Split(' ');
            int M = int.Parse(valores[0]);
            int N = int.Parse(valores[1]);

            int[,] A = new int[M, N];
            int[,] B = new int[M, N];
            int[,] C = new int[M, N];

            for (int i = 0; i < M; i++) {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    A[i, j] = int.Parse(valores[j]);
                }
            }

            for (int i = 0; i < M; i++) {
                valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    B[i, j] = int.Parse(valores[j]);
                }
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(C[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
