using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Secao_05_Aula_057_Auto_Properties
{
    internal class Produto
    {
        private string _nome;//Como esse atributo tem regras/lógicas diferentes, não é possivel usar o auto properties,
                             //então os gets e sets e a maneira como o atributo é declarado continua dessa forma.

        //Auto properties, é como se fosse o atributo + os gets e sets, e se precisar que algum deles sejam private ou protected,
        //é só colocar dentro do argumento como no exemplo abaixo.
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Em C# é assim que os "gets e sets" funcionam, esse é o properties, value nesse exemplo é como se fosse _nome = value/nome.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
