using System;

namespace Secao_05_Estruturas_Repetitivas_70
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1080*/

            int numero, maior, posicao;

            maior = 0;
            posicao = 0;
            for (int i = 1; i <= 100; i++) {
                numero = int.Parse(Console.ReadLine());
                if (numero > maior) {
                    maior = numero;
                    posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        }
    }
}
