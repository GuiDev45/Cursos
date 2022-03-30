using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_07
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1002*/

            //PI.
            double n = 3.14159;

            //Entrada de dados.
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo matemático.
            double area = n * (raio * raio);

            //Saída de dados.
            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
