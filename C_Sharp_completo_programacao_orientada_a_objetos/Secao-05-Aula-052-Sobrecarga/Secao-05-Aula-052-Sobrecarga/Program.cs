using System;
using System.Globalization;

namespace Secao_05_Aula_052_Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instância criada usando o construtor padrão/vazio. 
            Produto p2 = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();//Variável temporária, só para receber a entrada de dados que o usuário digitar.
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Variável temporária, só para receber a entrada de dados que o usuário digitar.

            //As variáveis temporarias vão cair nessa instância pois possuem o mesmo nome, que por sua vez vai passar para os atributos da classe Produto.
            //O construtor de apenas dois argumentos está sendo usado.
            Produto p = new Produto(nome, preco);

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
