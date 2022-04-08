using System;

namespace Secao_05_Estruturas_Repetitivas_52
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1113*/

            string[] vet = Console.ReadLine().Split(' ');

            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

            while(X != Y) {
                if (X > Y) {
                    Console.WriteLine("Decrescente");
                }
                else {
                    Console.WriteLine("Crescente");
                }
                vet = Console.ReadLine().Split(' ');

                X = int.Parse(vet[0]);
                Y = int.Parse(vet[1]);
            }
        }
    }
}
