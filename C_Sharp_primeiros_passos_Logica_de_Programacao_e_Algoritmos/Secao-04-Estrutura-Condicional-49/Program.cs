using System;

namespace Secao_03_Estrutura_Condicional_49
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1065*/

            int par = 0;

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());
            int num5 = int.Parse(Console.ReadLine());

            if (num1 % 2 == 0) {
                par += 1;
            }
            if (num2 % 2 == 0) {
                par += 1;
            }
            if (num3 % 2 == 0) {
                par += 1;
            }
            if (num4 % 2 == 0) {
                par += 1;
            }
            if (num5 % 2 == 0) {
                par += 1;
            }

            Console.WriteLine(par + " valores pares");
        }
    }
}
