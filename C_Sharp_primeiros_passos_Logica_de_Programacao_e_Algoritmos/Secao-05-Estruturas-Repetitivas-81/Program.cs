using System;

namespace Secao_05_Estruturas_Repetitivas_81
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1153*/

            int N = int.Parse(Console.ReadLine());
            double fatorial;
            int cont;

            fatorial = N;
            cont = N;
            
            for (int i = 1; i < cont; i++) {
                N--;
                fatorial *= N;
            }

            Console.WriteLine(fatorial);
        }
    }
}
