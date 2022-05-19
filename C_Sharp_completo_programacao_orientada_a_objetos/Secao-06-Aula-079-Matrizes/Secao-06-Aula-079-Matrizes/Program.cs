using System;

namespace Secao_06_Aula_079_Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            //Mostra quantos elementos a matriz tem no total.
            Console.WriteLine(mat.Length);

            //Mostra a quantidade de linhas da matriz.
            Console.WriteLine(mat.Rank);

            //Mostra a dimensão, basicamente a quantidade de linhas da dimensão 0 tem tamanho 2.
            Console.WriteLine(mat.GetLength(0));

            //Mostra a dimensão, basicamente a quantidade de colunas da dimensão 1 tem tamanho 3.
            Console.WriteLine(mat.GetLength(1));
        }
    }
}
