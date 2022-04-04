using System;

namespace Secao_03_Estrutura_Sequencial_23
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1018*/

            //Entrada de dados.
            int N = int.Parse(Console.ReadLine());

            //Cálculos para achar quantas notas de cada valor tem em N.
            int nota100 = N / 100;
            int resto = N % 50;

            int nota50 = resto / 50;
            resto = resto % 50;

            int nota20 = resto / 20;
            resto = resto % 20;

            int nota10 = resto / 10;
            resto = resto % 10;

            int nota5 = resto / 5;
            resto = resto % 5;

            int nota2 = resto / 2;
            resto = resto % 2;

            int nota1 = resto / 1;
            resto = resto % 1;

            //Saída de dados.
            Console.WriteLine(N);
            Console.WriteLine(nota100 + " nota(s) de R$ 100,00");
            Console.WriteLine(nota50 + " nota(s) de R$ 50,00");
            Console.WriteLine(nota20 + " nota(s) de R$ 20,00");
            Console.WriteLine(nota10 + " nota(s) de R$ 10,00");
            Console.WriteLine(nota5 + " nota(s) de R$ 5,00");
            Console.WriteLine(nota2 + " nota(s) de R$ 2,00");
            Console.WriteLine(nota1 + " nota(s) de R$ 1,00");
        }
    }
}
