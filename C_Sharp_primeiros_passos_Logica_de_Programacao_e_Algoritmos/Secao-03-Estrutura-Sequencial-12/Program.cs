using System;

namespace Secao_03_Estrutura_Sequencial_12
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1007*/

            //Entrada de dados.
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());
            int D = int.Parse(Console.ReadLine());

            //Cálculo matemático.
            int DIFERENCA = (A * B - C * D);

            //Saída de dados.
            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }   
    }
}
