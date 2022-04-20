using System;
using System.Globalization;

namespace Secao_07_Matrizes_108
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            6) Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
            a) calcular e imprimir a soma de todos os elementos positivos da matriz.
            b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
            c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
            d) imprimir os elementos da diagonal principal da matriz.
            e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.

            Entrada:
            A entrada contém o número inteiro N, seguido dos valores da matriz com uma casa decimal cada, seguido do índice de
            uma linha, seguido do índice de uma coluna, conforma exemplo.

            Saída:
            A saída contém os valores de saída de cada ação, com uma casa decimal, na ordem em que foram apresentadas no
            enunciado, conforme exemplo.

            Exemplo:
            Entrada                                             Saída
            3                                                   SOMA DOS POSITIVOS: 40.0
            7.0 -8.0 10.0                                       LINHA ESCOLHIDA: -2.0 3.0 5.0
            -2.0 3.0 5.0                                        COLUNA ESCOLHIDA: 10.0 5.0 4.0
            11.0 -15.0 4.0                                      DIAGONAL PRINCIPAL: 7.0 3.0 4.0
            1                                                   MATRIZ ALTERADA:
            2                                                   7.0 64.0 10.0
                                                                4.0 3.0 5.0
                                                                11.0 225.0 4.0
            */

            int N = int.Parse(Console.ReadLine());

            double[,] mat = new double[N, N];

            // leitura dos dados de entrada
            for (int i = 0; i < N; i++) {
                string[] valores = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++) {
                    mat[i, j] = double.Parse(valores[j], CultureInfo.InvariantCulture);
                }
            }

            int linha = int.Parse(Console.ReadLine());
            int coluna = int.Parse(Console.ReadLine());

            // a) soma dos positivos
            double soma = 0.0;
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] > 0.0) {
                        soma = soma + mat[i, j];
                    }
                }
            }
            Console.WriteLine("SOMA DOS POSITIVOS: " + soma.ToString("F1", CultureInfo.InvariantCulture));

            // b) imprimir os elementos da linha escolhida		
            Console.Write("LINHA ESCOLHIDA: ");
            for (int j = 0; j < N; j++) {
                Console.Write(mat[linha, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // c) imprimir os elementos da coluna escolhida		
            Console.Write("COLUNA ESCOLHIDA: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, coluna].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // d) imprimir a diagonal principal
            Console.Write("DIAGONAL PRINCIPAL: ");
            for (int i = 0; i < N; i++) {
                Console.Write(mat[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
            }
            Console.WriteLine();

            // e) alterar a matriz elevando os negativos ao quadrado
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    if (mat[i, j] < 0.0) {
                        mat[i, j] = mat[i, j] * mat[i, j];
                    }
                }
            }
            Console.WriteLine("MATRIZ ALTERADA:");
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(mat[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
