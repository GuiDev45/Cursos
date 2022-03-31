using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_15
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1010*/

            //Vetor de string recebendo entrada de dados e Split com o argumento (' ') se houver espaço na estrada de dados o vetor vai mudar para a próxima posição.
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            //Já que se trata de um vetor de string, o int.Parse foi usado.
            int codigo1 = int.Parse(vet1[0]);
            int quantidade1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            int codigo2 = int.Parse(vet2[0]);
            int quantidade2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            //Cálculo matemático.
            double valorTotal = (quantidade1 * valor1) + (quantidade2 * valor2);

            //Saída de dados com duas casas decimais.
            Console.WriteLine("VALOR A PAGAR: R$ " + valorTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
