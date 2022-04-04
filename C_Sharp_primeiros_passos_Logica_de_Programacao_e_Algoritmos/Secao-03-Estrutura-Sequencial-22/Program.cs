using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_22
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1017*/

            int automovel = 12;

            //Entrada de dados.
            double horaGasta = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double velocidadeMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo matemático.
            double combustivelGasto = (velocidadeMedia / automovel) * horaGasta;

            //Saída de dados.
            Console.WriteLine(combustivelGasto.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
