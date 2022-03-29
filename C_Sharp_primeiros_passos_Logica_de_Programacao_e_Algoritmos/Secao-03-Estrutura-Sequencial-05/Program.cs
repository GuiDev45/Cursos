using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_05
{
    class Program
    {
        static void Main(string[] args){
            /*Exercício Resolvido 01
            Olhar o pdf da seção 3*/

            //Entrada dos dados.
            Console.WriteLine("Digite a largura do terreno:");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o comprimento do terreno:");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite o preço do terreno:");
            double precoMetroQuadrado = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            //Cálculo Matemático.
            double area = largura * comprimento;
            double preco = area * precoMetroQuadrado;

            //Saída dos dados.
            Console.WriteLine("AREA = " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PREÇO = " + preco.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
