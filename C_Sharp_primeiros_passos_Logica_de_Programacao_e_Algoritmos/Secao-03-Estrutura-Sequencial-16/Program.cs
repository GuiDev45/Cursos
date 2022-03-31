using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_16
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1011*/

            //Entrada de dados.
            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Considerando o valor.
            double PI = 3.14159;

            //Cálculo matemático.
            double volume = (4.0 / 3.0) * PI * Math.Pow(R, 3.0);

            //Saída de dados.
            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
