using System;
using System.Globalization;

namespace Secao_05_Aula_055_Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            //Se não fosse private o atributo _quantidade que está na classe Produto, poderia ser alterado livremente dessa fora, corrompendo a integridade.
            //p._quantidade = -10;

            //Acessar tanto para entrada ou saída de dados, vai se usar o método set para entrada e get para saída, porém isso é mais a ideia do Java,
            //Em C# se usa o Properties.
            p.SetNome("TV 4K");

            //Essa chamada não daria certo, pela regra colocada no método set da classe Produto.
            p.SetNome("T");

            Console.WriteLine(p.GetNome());
        }
    }
}
