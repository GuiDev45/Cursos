using System;
using System.Globalization;

namespace Secao_05_Estruturas_Repetitivas_60
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1118*/
            
            int X = 1;
            double n1 = 0.0;
            double n2 = 0.0;
            double media = 0.0;
            double nota = 0.0;

            nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            while (X == 1) {
                while (nota < 0.0 || nota > 10.0) {
                    Console.WriteLine("nota invalida");
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                n1 = nota;

                nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                while (nota < 0.0 || nota > 10.0) {
                    Console.WriteLine("nota invalida");
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                n2 = nota;

                media = (n1 + n2) / 2.0;

                Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));

                Console.WriteLine("novo calculo (1-sim 2-nao)");
                X = int.Parse(Console.ReadLine());

                while (X < 1 || X > 2) {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    X = int.Parse(Console.ReadLine());
                }

                if (X == 1) {
                    nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

            }
        }
    }
}
