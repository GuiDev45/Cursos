using System;

namespace Secao_06_Aula_071_Exercicio_de_fixacao_vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] vet = new Aluguel[10];

            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + (i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                //A posição do vetor que vai ser preenchida é o valor do quarto, vet[posição do quarto que foi digitada].
                vet[quarto] = new Aluguel(nome, email);
            }

            Console.WriteLine();

            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vet[i] != null)//Como a posição do vetor vai ser dada pela entrada de valor que está na variável quarto, o que for nulo não vai imprimir.
                {
                    Console.WriteLine(i + ": " + vet[i]);
                }
            }
        }
    }
}
