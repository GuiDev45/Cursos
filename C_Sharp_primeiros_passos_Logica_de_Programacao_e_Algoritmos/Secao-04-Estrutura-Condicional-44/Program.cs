using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_44
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1043*/

            string[] vet = Console.ReadLine().Split(' ');

            double A = double.Parse(vet[0]);
            double B = double.Parse(vet[1]);
            double C = double.Parse(vet[2]);

            if (A < B + C && A > Math.Abs(B - C)) {
                double perimetro = A + B + C;
                Console.WriteLine("Perimetro = " + perimetro.ToString("F1", CultureInfo.InvariantCulture));
            }
            else {
                double area = (A + B) / 2.0 * C;
                Console.WriteLine("Area = " + area.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
