using System;
using System.Globalization;

namespace Secao_04_Aula_42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();//Criando o objeto e instanciando a classe.

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            //Usando o objeto prod criado, para invocar o atributo Nome.
            prod.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            prod.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            prod.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nDados do produto: {prod}\n");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());//Uma variável int normal recebendo entrada de dados.
            prod.AdicionarProdutos(qte);//Objeto prod invocando o método que está na classe Produto e usando a variável qte como argumento.

            Console.WriteLine($"\nDados atualizados: {prod}\n");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            prod.RemoverProdutos(qte);

            Console.WriteLine($"\nDados atualizados: {prod}\n");
        }
    }
}
