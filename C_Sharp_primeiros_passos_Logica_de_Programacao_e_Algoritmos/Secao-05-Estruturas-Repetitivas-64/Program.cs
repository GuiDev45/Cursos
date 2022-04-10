using System;

namespace Secao_05_Estruturas_Repetitivas_64
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1067*/

            int X = int.Parse(Console.ReadLine());

            for (int i = 1; i <= X; i++) {
                if (i % 2 != 0) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
