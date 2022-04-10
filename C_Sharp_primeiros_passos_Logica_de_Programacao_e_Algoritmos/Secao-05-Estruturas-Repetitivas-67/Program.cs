using System;

namespace Secao_05_Estruturas_Repetitivas_67
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1074*/

            int X = 0;

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++) {
                X = int.Parse(Console.ReadLine());

                if (X % 2 == 0 && X > 0) {
                    Console.WriteLine("EVEN POSITIVE");
                }
                if (X % 2 == 0 && X < 0) {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                if (X % 2 != 0 && X > 0) {
                    Console.WriteLine("ODD POSITIVE");
                }
                if (X % 2 != 0 && X < 0) {
                    Console.WriteLine("ODD NEGATIVE");
                }
                if (X == 0) {
                    Console.WriteLine("NULL");
                }
            } 
        }
    }
}
