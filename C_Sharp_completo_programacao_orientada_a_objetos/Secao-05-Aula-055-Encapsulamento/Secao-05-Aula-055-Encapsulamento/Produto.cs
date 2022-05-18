using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao_05_Aula_055_Encapsulamento
{
    internal class Produto
    {
        //Encapsulamento,
        //É private para não expor para outro arquivo algum atributo ou operação que possa prejudicar a integridade do Produto.
        public string _nome;//Por padrão do C# quando o atributo é privativo, se escreve com _ e letra minúscula.
        public double _preco;
        private int _quantidade;

        public Produto()
        {
            
        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //Tanto o Get como o Set é padrão de Java... da pra fazer, mas é para Java, em C# é o Properties.
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)//Há a possibilidade de colocar algumas regras básicas no método.
            {
                _nome = nome;
            }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
                + ", $"
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
