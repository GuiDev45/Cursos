using System;

namespace Secao_06_Aula_080_Exercicio_resolvido_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N,N];

            

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i,j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("diagonal: ");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }

            Console.WriteLine();

            int cont = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        cont++;
                    }
                }
            }

            Console.WriteLine("Números negativos: " + cont);
        }
    }
}
