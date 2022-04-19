using System;

namespace Secao_07_Matrizes_101
{
    class Program
    {
        static void Main(string[] args){
            int[,] matriz; //Declaração da matriz (poderia ser direto).

            int N = int.Parse(Console.ReadLine());

            matriz = new int[N, N]; //Quantas linhas e colunas a matriz vai ter.

            for (int i = 0; i < N; i++) {//for para as linhas.
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) { //for para as colunas.
                    matriz[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("DIAGONAL PRINCIPAL:");
            for (int i = 0; i < N; i++) {
                Console.Write(matriz[i, i] + " "); //Linha e coluna da matriz recebendo a mesma posição na saída de dados.
            }
            
            Console.WriteLine();

            int cont = 0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (matriz[i, j] < 0) {
                        cont++;
                    }
                }
            }
            Console.WriteLine("QUANTIDADE DE NEGATIVOS = " + cont);

        }
    }
}
