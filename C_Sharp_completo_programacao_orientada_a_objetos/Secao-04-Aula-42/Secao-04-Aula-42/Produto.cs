using System.Globalization;

namespace Secao_04_Aula_42
{
    internal class Produto
    {
        public string Nome;//Por padrão do C# os atributos começam com letra maiúscula.
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()//Não tem parâmetro de entrada, então os parênteses ficam vazios.
        {
            return Preco * Quantidade;
        }

        /*Não tem return porque é void/vazio, 
        a utilidade desse método é apenas somar o valor que entrar em seu arguemnto que no caso é o (int quantidade)
        e quem recebe essa quantidade mais ela mesma é o atributo Quantidade*/
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        //public, override para sobrescrever, do tipo string, e basta apenas o return para começar a concatenar.
        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}