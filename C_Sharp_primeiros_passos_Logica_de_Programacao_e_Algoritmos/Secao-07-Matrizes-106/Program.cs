using System;

namespace Secao_07_Matrizes_106
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            4) Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos acima da diagonal principal.
            
            Entrada:
            A entrada contém o valor N, depois os dados da matriz.

            Saída:
            A saída contém a soma dos elementos da diagonal principal.

            Exemplo:
            Entrada                 Saída
            3                       12
            10 3 2
            5 15 7
            8 6 4
            */

            int N = int.Parse(Console.ReadLine());

            int[,] mat = new int[N,N];

            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = int.Parse(valores[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < N; i++) {
                for (int j = i + 1; j < N; j++) {
                    soma = soma + mat[i, j];
                }
            }
            Console.WriteLine(soma);
        }
    }
}
