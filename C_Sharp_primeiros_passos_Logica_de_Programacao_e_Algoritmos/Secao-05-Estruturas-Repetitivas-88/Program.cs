using System;

namespace Secao_05_Estruturas_Repetitivas_88
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1150*/

            int X = int.Parse(Console.ReadLine());
            
            int cont = 1;
            int Y = 0;
            int soma = X;
            
            do {
                Y = int.Parse(Console.ReadLine());
            } while (Y <= X);
            
            while (Y >= soma) {
                X++;
                cont++;
                soma += X;
            }

            Console.WriteLine(cont);
        }
    }
}
