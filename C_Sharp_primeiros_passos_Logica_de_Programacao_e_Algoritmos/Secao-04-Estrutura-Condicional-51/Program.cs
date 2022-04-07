using System;

namespace Secao_03_Estrutura_Condicional_51
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1070*/

            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0) {
                x += 1;
            }

            Console.WriteLine(x);
            Console.WriteLine(x + 2);
            Console.WriteLine(x + 4);
            Console.WriteLine(x + 6);
            Console.WriteLine(x + 8);
            Console.WriteLine(x + 10);
        }
    }
}
