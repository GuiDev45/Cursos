using System;
using System.Globalization;

namespace Secao_03_Estrutura_Sequencial_13
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1008*/

            //Entrada de dados.
            int number = int.Parse(Console.ReadLine());
            int timeWork = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Cálculo matemático.
            double total = timeWork * salary;

            //Saída de dados.
            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
