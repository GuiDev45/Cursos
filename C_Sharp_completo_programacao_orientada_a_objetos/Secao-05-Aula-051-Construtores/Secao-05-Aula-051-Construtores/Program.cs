using System;
using System.Globalization;

namespace Secao_05_Aula_051_Construtores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();//Variável temporária, só para receber a entrada de dados que o usuário digitar.
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Variável temporária, só para receber a entrada de dados que o usuário digitar.
            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());//Variável temporária, só para receber a entrada de dados que o usuário digitar.

            //As variáveis temporarias vão cair nessa instância pois possuem o mesmo nome, que por sua vez vai passar para os atributos da classe Produto.
            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados dos produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
