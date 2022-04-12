using System;

namespace Secao_05_Estruturas_Repetitivas_77
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1142*/

            int N = int.Parse(Console.ReadLine());

            int cont = 0;
            int linhas = N * 4;

            for (int i = 1; i <= linhas; i++) {
                cont++;
                if (cont % 4 != 0) {
                    Console.Write(cont + " ");
                } 
                else {
                    Console.WriteLine("PUM");
                }
            }
        }
    }
}
