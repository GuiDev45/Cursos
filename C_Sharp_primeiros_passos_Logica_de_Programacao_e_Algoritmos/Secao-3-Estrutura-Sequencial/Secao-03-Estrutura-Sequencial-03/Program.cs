using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_03
{
    class Program
    {
        static void Main(string[] args){
            /*Exercício de Fixação
            Olhar o pdf da seção 3*/

            Console.WriteLine("Entre com seu nome completo:");
            string nomeCompleto = Console.ReadLine();

            Console.WriteLine("Quantos quartos têm na sua casa?");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int ano = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(ultimoNome);
            Console.WriteLine(ano);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
