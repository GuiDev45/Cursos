using System;
using System.Globalization;

namespace Secao_04_Aula_048_Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Variável vai ser usada no argumento do método.

            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);//Variável vai ser usada no argumento do método.

            /*Como o método é static não precisa criar o objeto instanciando a classe etc, 
            é só chamar o método e passar suas entradas como argumento (quantia, cotacao), 
            o cálculo já está pronto na classe ConversorDeMoeda.
            É basicamnete a mesma ideia do Math.Pow ou Math.sqrt*/
            double resultado = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
