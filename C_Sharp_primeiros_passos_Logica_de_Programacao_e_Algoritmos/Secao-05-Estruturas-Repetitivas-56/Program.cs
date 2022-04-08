using System;
using System.Globalization;

namespace Secao_05_Estruturas_Repetitivas_56
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1117*/
            
            double media = 0.0;
            double n1 = 0.0, n2 = 0.0;
            int cont = 0;

            double nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (cont < 2) {
                if (nota >= 0.0 && nota <= 10.0) {
                    if (cont == 0) {
                        n1 = nota;
                        nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    } 
                    else {
                        n2 = nota;
                    }
                    cont++;
                } 
                else {
                    Console.WriteLine("nota invalida");
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }

            media = (n1 + n2) / 2;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
