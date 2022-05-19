using System;
using System.Globalization;

namespace Secao_06_Aula_070_Vetores_parte_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Como é um vetor de instância, esse vetor está apontando no Heap, logo seus espaços estão valendo nulo.
            Produto[] produto = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produto[i] = new Produto { Name = nome, Preco = preco };//E assim se passa os valores que vão apontar para os espaços que estavam nulos.
            }

            double soma = 0.0;
            for (int i = 0; i < n; i++)
            {
                soma += produto[i].Preco;//Como o produto tem o nome e o preco em cada "espaço" do vetor, só de invocar o atributo .Preco,
                                         //ele já entende que a soma só vai pegar esse atributo.
            }

            double media = soma / n;
            Console.WriteLine("PREÇO MÉDIO = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
