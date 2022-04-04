using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_33
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1038*/

            //Vetor de string recebendo entrada de dados e Split com o argumento (' ') se houver espaço na estrada de dados o vetor vai mudar para a próxima posição.
            string[] vet = Console.ReadLine().Split(' ');

            //Já que se trata de um vetor de string, o int.Parse foi usado.
            int codigo = int.Parse(vet[0]);
            int qnt = int.Parse(vet[1]);

            //Declaração de variáveis.
            double preco = 0.0;

            //Estrutura Condicional, caso codigo seja...
            switch(codigo) {
                case 1:
                    preco += 4.00;
                    break;
                case 2:
                    preco += 4.50;
                    break;
                case 3:
                    preco += 5.00;
                    break;
                case 4:
                    preco += 2.00;
                    break;
                case 5:
                    preco += 1.50;
                    break;
                default:
                    break;
            }

            //Cálculo matemático.
            double total = qnt * preco;

            //Saída de dados.
            Console.WriteLine("Total: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
