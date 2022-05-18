using System;
using System.Globalization;

namespace Secao_05_Aula_057_Auto_Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            //Assim fica a sintaxe para a entrada de dados, objeto chamando o método Nome e passando o argumento.
            p.Nome = "TV 4K";

            //Assim fica a sintaxe para a saída de dados, objeto chamando o método Nome.
            Console.WriteLine(p.Nome);

            //Essa entrada não vai dar certo pela regra colocada no método Nome da classe Produto.
            p.Nome = "T";
            Console.WriteLine(p.Nome);

            //E assim ficou a saída de dados de todos os atributos que possuem "gets e sets"/Properties da classe Produto.
            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);
            Console.WriteLine(p.Quantidade);
        }
    }
}
