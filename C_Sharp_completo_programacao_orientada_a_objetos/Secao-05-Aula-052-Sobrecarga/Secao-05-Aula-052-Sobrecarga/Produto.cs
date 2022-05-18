using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao_05_Aula_052_Sobrecarga
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Sobrecarga, construtor padrão/vazio.
        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Sobrecarga, oferece mais de uma operação com o mesmo nome(no caso construtor do Produto), porém com diferentes listas de parâmetros.
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;//Pode passar um valor diretamente, quando esse construtor for criado em Program, esse valor já vai estar valendo.
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
