using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_20
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1015*/

            //Vetor de string recebendo entrada de dados e Split com o argumento (' ') se houver espaço na estrada de dados o vetor vai mudar para a próxima posição.
            string[] vet1 = Console.ReadLine().Split(' ');
            string[] vet2 = Console.ReadLine().Split(' ');

            //Já que se trata de um vetor de string, o int.Parse foi usado.
            double x1 = double.Parse(vet1[0], CultureInfo.InvariantCulture);
            double y1 = double.Parse(vet1[1], CultureInfo.InvariantCulture);

            double x2 = double.Parse(vet2[0], CultureInfo.InvariantCulture);
            double y2 = double.Parse(vet2[1], CultureInfo.InvariantCulture);

            //Cálculo matemático.
            double distancia = Math.Sqrt(Math.Pow(x1 - x2, 2.0) + Math.Pow(y1 - y2, 2.0));

            //Saída de dados.
            Console.WriteLine(distancia.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
