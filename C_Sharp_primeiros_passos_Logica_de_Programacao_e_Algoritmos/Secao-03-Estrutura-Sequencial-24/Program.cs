using System;

namespace Secao_03_Estrutura_Sequencial_24
{
    class Program
    {
        static void Main(string[] args){
            /*URI online judge Extremamente Básico 1019*/

            //Declaração das variáveis.
            int N, horas, minutos, segundos, resto;

            //Entrada de dados.
            N = int.Parse(Console.ReadLine());

            //Cálculo matemático
            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            //Saída de dados.
            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}
