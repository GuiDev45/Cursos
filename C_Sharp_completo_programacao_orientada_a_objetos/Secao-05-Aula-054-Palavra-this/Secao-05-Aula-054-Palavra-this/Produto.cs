using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao_05_Aula_054_Palavra_this
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto()
        {
            Quantidade = 10;
        }

        //Esse : this(), significa que o construtor padrão que tem um atributo Quantidade = 10, está sendo reaproveitado nesse construtor de 2 argumentos.
        //Então é como se o construtor que carrega o atributo Quantidade = 10 fizesse parte também desse construtor de 2 argumentos.
        public Produto(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        //Novamente, ao invés de copiar Nome = nome etc, com o : this(nome, preco) é possível reaproveitar o construtor acima.
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
