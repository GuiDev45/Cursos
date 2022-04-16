using System;

namespace Secao_06_Vetores_97
{
    class Program
    {
        static void Main(string[] args){
            /*Exercícios propostos
            6) Fazer um programa para ler um conjunto de nomes de pessoas e suas respectivas idades. 
            Depois, mostrar na tela o nome da pessoa mais velha.
            Exemplo:
            Entrada                                 Saída
            5                                       Pessoa mais velha: Carlos
            Joao 16
            Maria 21
            Teresa 15
            Carlos 23
            Paulo 17
            */

            Console.Write("Quantos números inteiros vão ser digitados ?: ");
            int N = int.Parse(Console.ReadLine());

            string [] nome = new string[N];
            int[] idade = new int[N];

            Console.WriteLine("Digite o nome e a idade da pessoa:");
            
            int maior = 0;
            string maisVelha = "";

            for (int i = 0; i < N; i++) {
                string[] s = Console.ReadLine().Split(' ');
                nome[i] = (s[0]);
                idade[i] = int.Parse(s[1]);

                if (idade[i] > maior) {
                    maior = idade[i];
                    maisVelha = nome[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pessoa mais velha: " + maisVelha);
        }
    }
}
