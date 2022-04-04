using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_29
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1036*/

            //Declaração das variáveis.
            double a, b, c, delta, r1, r2;

            //Vetor de string recebendo entrada de dados e Split com o argumento (' ') se houver espaço na estrada de dados o vetor vai mudar para a próxima posição.
            String[] vet = Console.ReadLine().Split(' ');

            //Já que se trata de um vetor de string, o int.Parse foi usado.
            a = Double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = Double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = Double.Parse(vet[2], CultureInfo.InvariantCulture);

            //Cálculo matemático.
            delta = Math.Pow(b, 2.0) - 4 * a * c;

            //Estrutura Condicional.
            if (a == 0 || delta < 0) {
                Console.WriteLine("Impossivel calcular");
            } 
            else {
                r1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                r2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("R1 = " + r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + r2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
