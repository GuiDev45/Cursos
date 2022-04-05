using System;
using System.Globalization;

namespace Secao_03_Estrutura_Condicional_39
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1045*/

            double A, B, C;

            string[] vet = Console.ReadLine().Split(' ');

            float num1 = float.Parse(vet[0], CultureInfo.InvariantCulture);
            float num2 = float.Parse(vet[1], CultureInfo.InvariantCulture);
            float num3 = float.Parse(vet[2], CultureInfo.InvariantCulture);

            if (Math.Max(num1, num2) > num3) {
                A = Math.Max(num1, num2);
                if (A > Math.Max(num2, num3)) {
                    B = Math.Max(num2, num3);
                    C = Math.Min(num2, num3);
                }
                else {
                    B = Math.Max(num1, num3);
                    C = Math.Min(num1, num3);
                }
            }
            else {
                A = num3;
                B = Math.Max(num1, num2);
                C = Math.Min(num1, num2);
            }

            if (A >= B + C) {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else {
                if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2)) {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if (Math.Pow(A, 2) > Math.Pow(B, 2) + Math.Pow(C, 2)) {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }

                if (A == B && B == C) {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B || A == C || B == C) {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
