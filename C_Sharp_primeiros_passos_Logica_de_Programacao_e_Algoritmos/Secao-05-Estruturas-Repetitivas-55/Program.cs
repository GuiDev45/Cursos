using System;

namespace Secao_05_Estruturas_Repetitivas_55
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1115*/

            string[] vet = Console.ReadLine().Split(' ');

            int X = int.Parse((vet[0]));
            int Y = int.Parse((vet[1]));

            while (X != 0 && Y != 0) {
                if (X > 0 && Y > 0) {
                    Console.WriteLine("primeiro");
                }
                if (X < 0 && Y > 0) {
                    Console.WriteLine("segundo");
                }
                if (X < 0 && Y < 0) {
                    Console.WriteLine("terceiro");
                }
                if (X > 0 && Y < 0) {
                    Console.WriteLine("quarto");
                }

                vet = Console.ReadLine().Split(' ');
                X = int.Parse((vet[0]));
                Y = int.Parse((vet[1]));
            }
        }
    }
}
