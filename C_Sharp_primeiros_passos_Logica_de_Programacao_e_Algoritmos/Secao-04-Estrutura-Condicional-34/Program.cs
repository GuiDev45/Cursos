using System;

namespace Secao_03_Estrutura_Condicional_34
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1044*/

            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

        }
    }
}
