using System;
using System.Globalization;

namespace Secao_06_Vetores_98
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            7) Fazer um programa para ler um conjunto de N nomes de alunos, bem como as notas que eles tiraram no 1º e 2º semestres.
            Cada uma dessas informações deve ser armazenada em um vetor. Depois, imprimir os nomes dos alunos aprovados,
            considerando aprovados aqueles cuja média das notas seja maior ou igual a seis.
            Exemplo:
            Entrada                                 Saída
            4                                       Alunos aprovados:
            Joao 7.0 8.5                            Joao
            Maria 9.2 6.5                           Maria
            Carlos 5.0 6.0                          Teresa
            Teresa 5.5 6.5
            */

            Console.Write("Quantos alunos vão ser digitados ?: ");
            int N = int.Parse(Console.ReadLine());

            string[] nome = new string[N];
            double[] nota1 = new double[N];
            double[] nota2 = new double[N];

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = (s[0]);
                nota1[i] = double.Parse(s[1], CultureInfo.InvariantCulture);
                nota2[i] = double.Parse(s[2], CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Alunos aprovados:");
            for (int i = 0; i < N; i++) {
                double media = (nota1[i] + nota2[i]) / 2.0;
                if (media >= 6.0) {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}
