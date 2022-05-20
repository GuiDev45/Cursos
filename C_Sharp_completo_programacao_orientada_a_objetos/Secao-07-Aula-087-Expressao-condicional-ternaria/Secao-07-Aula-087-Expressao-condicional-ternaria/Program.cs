using System;
using System.Globalization;

namespace Secao_07_Aula_087_Expressao_condicional_ternaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estrutura opcional ao if-else, quando se deseja decidir um VALOR com base em uma condição.

            //Sintaxe:
            // (condição) ? valor_se_verdadeiro : valor_se_falso

            //Exemplos:
            // ( 2 > 4 ) ? 50 : 80 -------> 80. 2 é maior que 4 ? não, então a saída é 80.
            // (10 != 3 ) ? "Maria" : "Alex" --------> "Maria". 10 é diferente de 3 ? sim então a saída é "Maria"

            double preco = 34.5;
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            //Porém com a condição ternária é menos código e faz o mesmo resultado.

            double preco2 = 34.5;
            double desconto2 = (preco2 < 20.0) ? preco2 * 0.1 : preco2 * 0.05;
        }
    }
}
